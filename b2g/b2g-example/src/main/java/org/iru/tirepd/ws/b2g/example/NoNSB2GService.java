package org.iru.tirepd.ws.b2g.example;

import java.net.MalformedURLException;
import java.net.URL;
import java.util.UUID;

import javax.jws.WebService;
import javax.servlet.ServletContext;
import javax.xml.ws.handler.MessageContext;

import org.apache.commons.io.IOUtils;
import org.iru.epd.message.CUSOFFDEPEPTType;
import org.iru.epd.message.EPD015;
import org.iru.epd.message.EPD928;
import org.iru.tirepd.messages.names.NoNamespaceMapper;
import org.iru.tirepd.ws.b2g_1.TIREPDB2GUploadAck;
import org.iru.tirepd.ws.b2g_1.TIREPDB2GUploadParams;
import org.iru.tirepd.ws.g2b.client.NoNSG2BClient;

@WebService(endpointInterface="org.iru.tirepd.ws.b2g_1.TIREPDB2GServiceClassSoap")
public class NoNSB2GService extends AbstractB2GExampleService {

	private Object clientInitLock = new Object();
	private boolean clientInited = false;
	private NoNSG2BClient g2b;
	private URL g2bEndpoint;

	private ThreadLocal<Object> syncReplyMessage = new ThreadLocal<Object>();
		
	@Override
	protected Class<?> lookupMessageName(String messageName) {
		return NoNamespaceMapper.getB2GClass(messageName);
	}

	@Override
	protected void processMessageContent(Object messageContent, String messageName)	throws Exception {
		log.info(messageName+" => "+messageContent.getClass().getName());
		if (messageContent instanceof EPD015) {
			EPD015 epd = (EPD015) messageContent;

			EPD928 epdReceived = new EPD928();
			EPD928.HEAHEA heahea = new EPD928.HEAHEA();
			epdReceived.setHEAHEA(heahea);
			heahea.setRefNumHEA4(epd.getHEAHEA().getRefNumHEA4());

			CUSOFFDEPEPTType cusoffdepept = new CUSOFFDEPEPTType();
			epdReceived.setCUSOFFDEPEPT(cusoffdepept);
			cusoffdepept.setRefNumEPT1(epd.getCUSOFFDEPEPT().getRefNumEPT1());

			syncReplyMessage.set(epdReceived);
		}
	}

	@Override
	public TIREPDB2GUploadAck tirepdb2G(TIREPDB2GUploadParams su) {
		TIREPDB2GUploadAck ack = super.tirepdb2G(su);

		synchronized (clientInitLock) {
			if (! clientInited) {
				g2b = new NoNSG2BClient();
				g2b.setSender(subscriber); // used in both directions for simplicity
				
				MessageContext mctx = context.getMessageContext();
				ServletContext sctx = (ServletContext) mctx.get(MessageContext.SERVLET_CONTEXT);

				String p = sctx.getInitParameter("G2BEndoint");
				try {
					g2bEndpoint = new URL(p);
					g2b.setEPDG2BEndpoint(g2bEndpoint);
				} catch (MalformedURLException e) {
					log.warn("Could not resolve G2BEndpoint URL: "+p, e);
				}
				
				String iruCert = sctx.getInitParameter("IRUCertificateFile");
				try {
					g2b.setIruCertificate(IOUtils.toByteArray(Thread.currentThread().getContextClassLoader().getResourceAsStream(iruCert))); 
				} catch (Exception e) {
					log.warn("Could not load IRUCertificateFile: "+iruCert, e);
				}

				clientInited = true;
			}
		}

		String messageID = UUID.randomUUID().toString(); 
		try {
			Object replyContent = syncReplyMessage.get();
			syncReplyMessage.set(null);
			int rc = g2b.upload(messageID, replyContent);
			log.info("G2B messageID "+messageID+" to "+g2bEndpoint+": rc = "+rc);
		} catch (Exception e) {
			log.warn("G2B messageID "+messageID+" to "+g2bEndpoint+": "+e.getMessage(), e);
		}
		
		return ack;
	}

}



