package org.iru.rtsplus.client.classic;

import java.net.URL;
import java.util.Collections;

import org.iru.rtsplus.client.CarnetServiceClient;
import org.iru.rtsplus.client.ClientFactory;
import org.iru.rtsplus.client.TerminationServiceClient;

public class ClientFactoryImpl implements ClientFactory {

	private byte[] outgoingCertificate;
	private byte[] incomingCertificate;
	private byte[] incomingKey;
	private String sender;

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

	private void setAbstractWSSClientProperties(AbstractWSSClient c, URL wsdlLocation) {
		c.setSender(sender);
		c.setRtsEndpoint(wsdlLocation);
		c.setIruCertificateData(outgoingCertificate);
		try {
			c.setIncomingCertificateToPrivateKeys(Collections.singletonMap(incomingCertificate, incomingKey));
		} catch (Exception e) {
			throw new SecurityException(e);
		}
	}
	
	@Override
	public CarnetServiceClient getCarnetServiceClient(URL wsdlLocation) {
		CarnetServiceClientImpl c = new CarnetServiceClientImpl();
		setAbstractWSSClientProperties(c, wsdlLocation);
		return c;
	}

	@Override
	public TerminationServiceClient getTerminationServiceClient(URL wsdlLocation) {
		TerminationServiceClientImpl c = new TerminationServiceClientImpl();
		setAbstractWSSClientProperties(c, wsdlLocation);
		return c;
	}

}
