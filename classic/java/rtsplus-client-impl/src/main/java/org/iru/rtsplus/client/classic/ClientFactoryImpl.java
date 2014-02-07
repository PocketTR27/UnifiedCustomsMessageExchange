package org.iru.rtsplus.client.classic;

import java.net.URL;
import java.util.Collections;

import org.iru.rtsplus.client.CarnetServiceClient;
import org.iru.rtsplus.client.ClientFactory;
import org.iru.rtsplus.client.TerminationServiceClient;
import org.iru.rts.client.HolderQueryClient;
import org.iru.rts.client.ReconciliationClient;
import org.iru.rts.client.UploadClient;
import org.iru.rts.client.classic.AbstractClient;
import org.iru.rts.client.classic.AbstractQueryClient;
import org.iru.rts.client.classic.HolderQueryClientImpl;
import org.iru.rts.client.classic.ReconciliationClientImpl;

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

	private void setAbstractWSSClientProperties(AbstractWSSClient c) {
		c.setSender(sender);
		c.setRtsEndpoint(wsdlLocation);
		c.setIruCerficateData(outgoingCertificate);
		try {
			c.setIncomingCertificateToPrivateKeys(Collections.singletonMap(incomingCertificate, incomingKey));
		} catch (Exception e) {
			throw new SecurityException(e);
		}
	}
	
	@Override
	public CarnetServiceClient getCarnetServiceClient() {
		CarnetServiceClientImpl c = new CarnetServiceClientImpl();
		setAbstractWSSClientProperties(c);
		return c;
	}

	@Override
	public TerminationServiceClient getTerminationServiceClient() {
		TerminationServiceClientImpl c = new TerminationServiceClientImpl();
		setAbstractWSSClientProperties(c);
		return c;
	}

}
