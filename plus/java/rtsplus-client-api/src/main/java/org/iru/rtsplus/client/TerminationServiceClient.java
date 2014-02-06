package org.iru.rtsplus.client;

import java.util.Date;
import java.util.Set;

import javax.xml.datatype.DatatypeConfigurationException;

import org.iru.rts.model.termination_1.ReconciliationRequestRepliesType;
import org.iru.rts.model.termination_1.ReconciliationRequestType;
import org.iru.rts.model.termination_1.TIROperationTerminationsType;

public interface TerminationServiceClient {

	public void transmitTIROperationTerminations(TIROperationTerminationsType tirOperationTerminations, String transmissionId, Date transmissionTime) throws DatatypeConfigurationException;
	
	public Set<ReconciliationRequestType> getReconciliationRequests(Date from, Date to, Long retrievalRange) throws DatatypeConfigurationException;
	
	public void transmitReconciliationRequestReplies(ReconciliationRequestRepliesType reconciliationRequestReplies, String transmissionId, Date transmissionTime) throws DatatypeConfigurationException;
	
}
