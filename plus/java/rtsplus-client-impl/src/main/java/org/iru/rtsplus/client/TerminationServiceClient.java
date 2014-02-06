package org.iru.rtsplus.client;

import java.math.BigInteger;
import java.util.Date;
import java.util.LinkedHashSet;
import java.util.Set;

import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.XMLGregorianCalendar;
import javax.xml.namespace.QName;
import javax.xml.ws.soap.AddressingFeature;

import org.iru.rts.model.termination_1.ReconciliationRequestRepliesType;
import org.iru.rts.model.termination_1.ReconciliationRequestType;
import org.iru.rts.model.termination_1.TIROperationTerminationsType;
import org.iru.rts.services.terminationservice_1.ReconciliationRequestsType;
import org.iru.rts.services.terminationservice_1.TerminationService;
import org.iru.rts.services.terminationservice_1.TerminationServiceSEI;
import org.iru.rts.services.terminationservice_1.TransmitReconciliationRequestReplies;
import org.iru.rts.services.terminationservice_1.TransmitTIROperationTerminations;

public class TerminationServiceClient extends AbstractWSSClient {

	private Long retrievalRange;

	protected QName getServiceQName() {
		return new QName("http://rts.iru.org/services/TerminationService-1", "TerminationService");
	}
	
	protected QName getPortQName() {
		return new QName("http://rts.iru.org/services/TerminationService-1", "TerminationServicePort"+portNameSuffix);
	}
	
	protected TerminationServiceSEI getWsPort() {
		return getWsPort(TerminationService.class, TerminationServiceSEI.class);
	}

	public void transmitTIROperationTerminations(TIROperationTerminationsType tirOperationTerminations, String transmissionId) throws DatatypeConfigurationException {
		transmitTIROperationTerminations(tirOperationTerminations, transmissionId, new Date());
	}

	public void transmitTIROperationTerminations(TIROperationTerminationsType tirOperationTerminations, String transmissionId, Date transmissionTime) throws DatatypeConfigurationException {
		TransmitTIROperationTerminations parameters = new TransmitTIROperationTerminations();
		parameters.setTIROperationTerminations(tirOperationTerminations);
		parameters.setTransmissionId(transmissionId);
		parameters.setTransmissionTime(convertToXML(transmissionTime));

		TerminationServiceSEI wsPort = getWsPort();
		wsPort.transmitTIROperationTerminations(parameters);     
	}

	public void setReconciliationRequestRetrievalRange(Long retrievalRange) {
		this.retrievalRange = retrievalRange;
	}

	public Set<ReconciliationRequestType> getReconciliationRequests(Date from, Date to) throws DatatypeConfigurationException {
		TerminationServiceSEI wsPort = getWsPort();

		XMLGregorianCalendar xFrom = convertToXML(from); 
		XMLGregorianCalendar xTo = convertToXML(to);

		int offset = 0;

		Set<ReconciliationRequestType> reconciliationRequests = new LinkedHashSet<ReconciliationRequestType>();
		while (true) {
			ReconciliationRequestsType.ReconciliationRequests data = wsPort.getReconciliationRequests(xFrom, xTo, BigInteger.valueOf((long) offset), retrievalRange).getReconciliationRequests();
			reconciliationRequests.addAll(data.getReconciliationRequest());
			retrievalRange = (long) data.getCount();
			if (data.isEndReached())
				break;
			else
				offset = data.getOffset()+data.getCount();
		}
		return reconciliationRequests;
	}

	public void transmitReconciliationRequestReplies(ReconciliationRequestRepliesType reconciliationRequestReplies, String transmissionId, Date transmissionTime) throws DatatypeConfigurationException {
		TransmitReconciliationRequestReplies parameters = new TransmitReconciliationRequestReplies();
		parameters.setReconciliationRequestReplies(reconciliationRequestReplies);
		parameters.setTransmissionId(transmissionId);
		parameters.setTransmissionTime(convertToXML(transmissionTime));

		TerminationServiceSEI wsPort = getWsPort();
		wsPort.transmitReconciliationRequestReplies(parameters);     
	}

	 
}
