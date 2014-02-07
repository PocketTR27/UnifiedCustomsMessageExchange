package org.iru.rts.client.plus;

import java.net.URL;

import org.iru.rts.client.ClientFactory;
import org.iru.rts.client.HolderQueryClient;
import org.iru.rts.client.ReconciliationClient;
import org.iru.rts.client.UploadClient;
import org.iru.rtsplus.client.plus.AbstractWSSClient;

public class ClientFactoryImpl implements ClientFactory {


	private URL wsdlLocation;
	private byte[] outgoingCertificate;
	private byte[] outgoingKey;
	private byte[] incomingCertificate;

	@Override
	public void setWsdlLocation(URL wsdlLocation) {
		this.wsdlLocation = wsdlLocation;
	}

	@Override
	/**
	 * This method does nothing as the authentication is based on the signature
	 */
	public void setSender(String sender) {}

	@Override
	public void setOutgoingCertificate(byte[] certificate) {
		this.outgoingCertificate = certificate;
		
	}
	
	@Override
	public void setOutgoingKey(byte[] key) {
		this.outgoingKey = key;
		
	}

	@Override
	public void setIncomingCertificate(byte[] certificate) {
		this.incomingCertificate = certificate;
		
	}

	@Override
	/**
	 * This method does nothing as there is not message encryption
	 */
	public void setIncomingKey(byte[] key) {}

	
	@Override
	public HolderQueryClient getHolderQueryClient() {
		HolderQueryClientImpl c = new HolderQueryClientImpl();
		setAbstractWSSClientProperties(c);
		return c;
	}

	private void setAbstractWSSClientProperties(AbstractWSSClient c) {
		c.setRtsEndpoint(wsdlLocation);
		c.setPortNameSuffix("_2"); // port using X509
		try {
			c.setSigningCertificateDER(outgoingCertificate);
			c.setSigningKeyDER(outgoingKey);
			c.setVerifyingCertificateDER(incomingCertificate);
		} catch (Exception e) {
			throw new SecurityException(e);
		}
	}
	

	@Override
	public ReconciliationClient getReconciliationClient() {
		ReconciliationClientImpl c = new ReconciliationClientImpl();
		setAbstractWSSClientProperties(c);
		return c;
	}

	@Override
	public UploadClient getUploadClient() {
		UploadClientImpl c = new UploadClientImpl();
		setAbstractWSSClientProperties(c);
		return c;
	}

}
