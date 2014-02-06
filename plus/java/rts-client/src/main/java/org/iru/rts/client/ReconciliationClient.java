package org.iru.rts.client;

import java.io.IOException;
import java.math.BigInteger;
import java.security.GeneralSecurityException;
import java.util.ArrayList;
import java.util.List;
import java.util.Set;

import javax.xml.bind.JAXBException;
import javax.xml.datatype.DatatypeConfigurationException;

import org.iru.rts.converter.WSRQConverter;
import org.iru.rts.model.termination_1.MissingTIROperationTerminationType;
import org.iru.rts.model.termination_1.ReconciliationRequestType;
import org.iru.rts.model.termination_1.TIROperationTerminationType;
import org.iru.rts.safetirreconciliation.RequestRecords;
import org.iru.rtsplus.client.TerminationServiceClient;

public class ReconciliationClient extends TerminationServiceClient {

	public List<RequestRecords.RequestRecord> downloadReconciliationRequests(String senderMessageID) throws JAXBException, GeneralSecurityException, IOException, DatatypeConfigurationException {	
		Set<ReconciliationRequestType> requests = getReconciliationRequests(null, null);
		
		List<RequestRecords.RequestRecord> records = new ArrayList<RequestRecords.RequestRecord>(requests.size());
		for (ReconciliationRequestType request : requests) {
			RequestRecords.RequestRecord record = new RequestRecords.RequestRecord();
			record.setRequestID(request.getId());
			record.setRequestDate(request.getDate());
			record.setRequestReminderNum((int) request.getReminderCount());
			record.setRequestDataSource(WSRQConverter.convertReasonToRequestDataSource(request.getReason()));
	
			record.setRequestRemark(request.getRemark());
			switch (request.getReason()) {
			case MISSING:
				{
					MissingTIROperationTerminationType termination = request.getMissingTIROperationTermination();
					record.setTNO(termination.getTIRCarnetNumber());
					record.setICC(termination.getCustoms().getCountryCode());
					record.setVPN(BigInteger.valueOf(termination.getVoletPageNumber()));
				}
				break;
			case DISCREPANCY:
				{
					TIROperationTerminationType termination = request.getTIROperationTerminationToValidate();
					record.setTNO(termination.getTIRCarnetNumber());
					record.setICC(termination.getCustoms().getCountryCode());
					record.setDCL(termination.getCustomsLedgerEntryDate());
					record.setCNL(termination.getCustomsLedgerEntryReference());
					record.setCOF(termination.getCustomsOffice());
					record.setDDI(termination.getCertificateOfTerminationDate());
					record.setRND(termination.getCertificateOfTerminationReference());
					StringBuilder sb = new StringBuilder();
					sb.append(termination.isIsFinal() ? "FD" : "PD");
					if (termination.getSequenceNumber() != null)
						sb.append(termination.getSequenceNumber());
					record.setPFD(sb.toString());
					record.setCWR(termination.isIsWithReservation() ? "R" : "OK");
					record.setVPN(BigInteger.valueOf(termination.getVoletPageNumber()));
					record.setCOM(termination.getCustomsComment());
					record.setPIC(termination.getPackageCount() != null ? BigInteger.valueOf(termination.getPackageCount()) : null);
				}
				break;
			}
			records.add(record);
		}
		
		return records;
	}

}
