package org.iru.rtsplus.client.plus;

import java.net.URL;

import org.iru.rtsplus.client.CarnetServiceClient;
import org.iru.rtsplus.client.ClientFactory;
import org.iru.rtsplus.client.TerminationServiceClient;

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
	public CarnetServiceClient getCarnetServiceClient() {
		CarnetServiceClientImpl c = new CarnetServiceClientImpl();
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
	public TerminationServiceClient getTerminationServiceClient() {
		TerminationServiceClientImpl c = new TerminationServiceClientImpl();
		setAbstractWSSClientProperties(c);
		return c;
	}


}
