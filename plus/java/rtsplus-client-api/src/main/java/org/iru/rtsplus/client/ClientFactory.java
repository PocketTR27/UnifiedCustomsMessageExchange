package org.iru.rtsplus.client;

import java.net.URL;

public interface ClientFactory {

	CarnetServiceClient getCarnetServiceClient();
	TerminationServiceClient getTerminationServiceClient();
	
	public void setSender(String sender);
	
	public void setWsdlLocation(URL wsdlLocation);
	
	public void setOutgoingCertificate(byte[] certificate);
	public void setOutgoingKey(byte[] key);
	
	public void setIncomingCertificate(byte[] certificate);
	public void setIncomingKey(byte[] key);
}
