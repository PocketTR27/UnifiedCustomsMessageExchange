package org.iru.rts.client;

import java.net.URL;

public interface ClientFactory {

	HolderQueryClient getHolderQueryClient(URL wsdlLocation);
	ReconciliationClient getReconciliationClient(URL wsdlLocation);
	UploadClient getUploadClient(URL wsdlLocation);
	
	public void setSender(String sender);
	
	public void setOutgoingCertificate(byte[] certificate);
	public void setOutgoingKey(byte[] key);
	
	public void setIncomingCertificate(byte[] certificate);
	public void setIncomingKey(byte[] key);
}
