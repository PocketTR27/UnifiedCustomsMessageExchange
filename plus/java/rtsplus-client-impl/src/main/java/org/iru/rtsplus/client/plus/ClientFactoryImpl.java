package org.iru.rtsplus.client.plus;

import java.net.URL;

import org.iru.rtsplus.client.CarnetServiceClient;
import org.iru.rtsplus.client.ClientFactory;
import org.iru.rtsplus.client.TerminationServiceClient;

public class ClientFactoryImpl implements ClientFactory {

	private byte[] outgoingCertificate;
	private byte[] outgoingKey;
	private byte[] incomingCertificate;

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
	public CarnetServiceClient getCarnetServiceClient(URL wsdlLocation) {
		CarnetServiceClientImpl c = new CarnetServiceClientImpl();
		setAbstractWSSClientProperties(c, wsdlLocation);
		return c;
	}

	private void setAbstractWSSClientProperties(AbstractWSSClient c, URL wsdlLocation) {
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
	public TerminationServiceClient getTerminationServiceClient(URL wsdlLocation) {
		TerminationServiceClientImpl c = new TerminationServiceClientImpl();
		setAbstractWSSClientProperties(c, wsdlLocation);
		return c;
	}


}
