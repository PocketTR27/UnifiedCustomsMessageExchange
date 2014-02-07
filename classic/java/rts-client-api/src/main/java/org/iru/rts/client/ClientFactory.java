package org.iru.rts.client;

import java.net.URL;

public interface ClientFactory {

	HolderQueryClient getHolderQueryClient();
	ReconciliationClient getReconciliationClient();
	UploadClient getUploadClient();
	
	public void setSender(String sender);
	
	public void setWsdlLocation(URL wsdlLocation);
	
	public void setOutgoingCertificate(byte[] certificate);
	public void setOutgoingKey(byte[] key);
	
	public void setIncomingCertificate(byte[] certificate);
	public void setIncomingKey(byte[] key);
}
