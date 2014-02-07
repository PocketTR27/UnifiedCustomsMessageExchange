package org.iru.rts.client.classic;

import java.net.URL;
import java.util.Collections;

import org.iru.rts.client.ClientFactory;
import org.iru.rts.client.HolderQueryClient;
import org.iru.rts.client.ReconciliationClient;
import org.iru.rts.client.UploadClient;

public class ClientFactoryImpl implements ClientFactory {


	private URL wsdlLocation;
	private byte[] outgoingCertificate;
	private byte[] incomingCertificate;
	private byte[] incomingKey;
	private String sender;

	@Override
	public void setWsdlLocation(URL wsdlLocation) {
		this.wsdlLocation = wsdlLocation;
	}

	@Override
	public void setSender(String sender) {
		this.sender = sender;
	}

	@Override
	public void setOutgoingCertificate(byte[] certificate) {
		this.outgoingCertificate = certificate;
	}

	@Override
	/**
	 * This method does nothing as there is not message signature
	 */
	public void setOutgoingKey(byte[] key) {}


	@Override
	public void setIncomingCertificate(byte[] certificate) {
		this.incomingCertificate = certificate;
		
	}

	@Override
	public void setIncomingKey(byte[] key) {
		this.incomingKey = key;
	}

	
	@Override
	public HolderQueryClient getHolderQueryClient() {
		HolderQueryClientImpl c = new HolderQueryClientImpl();
		setAbstractQueryClientProperties(c);
		return c;
	}

	private void setAbstractQueryClientProperties(AbstractQueryClient c) {
		setAbstractClientProperties(c);
		try {
			c.setIncomingCertificateToPrivateKeys(Collections.singletonMap(incomingCertificate, incomingKey));
		} catch (Exception e) {
			throw new SecurityException(e);
		}
	}
	
	private void setAbstractClientProperties(AbstractClient c) {
		c.setSender(sender);
		c.setRtsEndpoint(wsdlLocation);
		c.iruCertificate = outgoingCertificate;
	}
	

	@Override
	public ReconciliationClient getReconciliationClient() {
		ReconciliationClientImpl c = new ReconciliationClientImpl();
		setAbstractQueryClientProperties(c);
		return c;
	}

	@Override
	public UploadClient getUploadClient() {
		UploadClientImpl c = new UploadClientImpl();
		setAbstractClientProperties(c);
		return c;
	}



}
