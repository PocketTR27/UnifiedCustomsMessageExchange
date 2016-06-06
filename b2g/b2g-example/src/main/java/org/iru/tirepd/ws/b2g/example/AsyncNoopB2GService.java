package org.iru.tirepd.ws.b2g.example;

import javax.jws.WebService;

import org.iru.tirepd.ws.b2g_1.TIREPDB2GUploadAck;
import org.iru.tirepd.ws.b2g_1.TIREPDB2GUploadParams;

@WebService(endpointInterface="org.iru.tirepd.ws.b2g_1.TIREPDB2GServiceClassSoap")
public class AsyncNoopB2GService extends AbstractB2GExampleService {

	@Override
	protected Class<?> lookupMessageName(String messageName) {
		return String.class;
	}

	@Override
	protected void processMessageContent(String subscriberMessageID, Object messageContent, String messageName)
			throws Exception {
		String message = (String) messageContent;
		log.info(messageName+" => "+message);
	}

	/*
	 * WAS needs the methods in the WebService class, even if superclass already implements it 
	 */
	@Override
	public TIREPDB2GUploadAck tirepdb2G(TIREPDB2GUploadParams su) {
		return super.tirepdb2G(su);
	}



}
