package org.iru.rts.client;

import java.io.IOException;
import java.security.GeneralSecurityException;
import java.util.List;

import javax.xml.bind.JAXBException;
import javax.xml.datatype.DatatypeConfigurationException;

import org.iru.rts.safetirreconciliation.RequestRecords;

public interface ReconciliationClient {

	public List<RequestRecords.RequestRecord> downloadReconciliationRequests(String senderMessageID) throws JAXBException, GeneralSecurityException, IOException, DatatypeConfigurationException;
	
}
