package org.iru.rts.client;

import java.security.GeneralSecurityException;
import java.util.Date;
import java.util.List;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.JAXBException;
import javax.xml.datatype.DatatypeConfigurationException;

import org.iru.model.tir_actor_1.Customs;
import org.iru.rts.converter.WSREConverter;
import org.iru.rts.model.termination_1.ObjectFactory;
import org.iru.rts.model.termination_1.ReconciliationRequestRepliesType;
import org.iru.rts.model.termination_1.ReconciliationRequestReplyType;
import org.iru.rts.model.termination_1.TIROperationTerminationType;
import org.iru.rts.model.termination_1.TIROperationTerminationsType;
import org.iru.rts.safetirupload.CWRType;
import org.iru.rts.safetirupload.PFDType;
import org.iru.rts.safetirupload.Records;
import org.iru.rts.safetirupload.RequestReplyRecords;
import org.iru.rts.safetirupload.UPGType;
import org.iru.rtsplus.client.TerminationServiceClientImpl;

public class UploadClientImpl extends TerminationServiceClientImpl implements UploadClient {
	
	public ReturnCode wsst(List<Records.Record> safeTIRRecords, String messageID) throws JAXBException, GeneralSecurityException, DatatypeConfigurationException {
		return wsst(safeTIRRecords, messageID, new Date());
	}
	
	@Override
	public ReturnCode wsst(List<Records.Record> safeTIRRecords, String messageID, Date sentTime) throws JAXBException, GeneralSecurityException, DatatypeConfigurationException {
		TIROperationTerminationsType terminations = new TIROperationTerminationsType();
		ObjectFactory of = new ObjectFactory();
		try {
			for (Records.Record safeTIRRecord: safeTIRRecords) {
				TIROperationTerminationType termination = new TIROperationTerminationType();
				termination.setTIRCarnetNumber(safeTIRRecord.getTNO());
				termination.setVoletPageNumber(safeTIRRecord.getVPN().shortValue());
				Customs customs = new Customs();
				customs.setCountryCode(safeTIRRecord.getICC());
				termination.setCustoms(customs);
				termination.setCustomsOffice(safeTIRRecord.getCOF());
				termination.setCustomsLedgerEntryReference(safeTIRRecord.getCNL());
				termination.setCustomsLedgerEntryDate(safeTIRRecord.getDCL());
				termination.setCertificateOfTerminationReference(safeTIRRecord.getRND());
				termination.setCertificateOfTerminationDate(safeTIRRecord.getDDI());
				termination.setIsFinal(safeTIRRecord.getPFD().equals(PFDType.FD));
				termination.setIsWithReservation(safeTIRRecord.getCWR().equals(CWRType.R));
				termination.setCustomsComment(safeTIRRecord.getCOM());
				termination.setPackageCount(safeTIRRecord.getPIC() != null ? safeTIRRecord.getPIC().longValue() : null);

				JAXBElement<TIROperationTerminationType> t;
				if (safeTIRRecord.getUPG().equals(UPGType.N)) {
					t = of.createNewTIROperationTermination(termination);
				} else {
					t = of.createCancelledTIROperationTermination(termination);
				}
				terminations.getNewTIROperationTerminationOrCancelledTIROperationTerminationOrUpdatedTIROperationTermination().add(t);
			}
			terminations.setCount((long) terminations.getNewTIROperationTerminationOrCancelledTIROperationTerminationOrUpdatedTIROperationTermination().size());
			transmitTIROperationTerminations(terminations, messageID, sentTime);
		} catch (Exception e) {
			return ReturnCode.UNCLASSIFIED_ERROR;
		}
		return ReturnCode.SUCCESS;
	}

	@Override
	public ReturnCode wsre(List<RequestReplyRecords.RequestReplyRecord> rrRecords, String messageID) throws JAXBException, GeneralSecurityException, DatatypeConfigurationException {
		ReconciliationRequestRepliesType reconciliationRequestReplies = new ReconciliationRequestRepliesType();
		try {
			for (RequestReplyRecords.RequestReplyRecord rrRecord : rrRecords) {
				ReconciliationRequestReplyType requestReply = new ReconciliationRequestReplyType();
				requestReply.setId(rrRecord.getRequestID());
				requestReply.setReplyType(WSREConverter.convertRequestReplyToReplyType(rrRecord.getRequestReplyType()));
				TIROperationTerminationType termination = new TIROperationTerminationType();
				termination.setTIRCarnetNumber(rrRecord.getTNO());
				termination.setVoletPageNumber(rrRecord.getVPN().shortValue());
				Customs customs = new Customs();
				customs.setCountryCode(rrRecord.getICC());
				termination.setCustoms(customs);
				termination.setCustomsOffice(rrRecord.getCOF());
				termination.setCustomsLedgerEntryReference(rrRecord.getCNL());
				termination.setCustomsLedgerEntryDate(rrRecord.getDCL());
				termination.setCertificateOfTerminationReference(rrRecord.getRND());
				termination.setCertificateOfTerminationDate(rrRecord.getDDI());
				termination.setIsFinal(rrRecord.getPFD().equals(PFDType.FD));
				termination.setIsWithReservation(rrRecord.getCWR().equals(CWRType.R));
				termination.setCustomsComment(rrRecord.getCOM());
				termination.setPackageCount(rrRecord.getPIC() != null ? rrRecord.getPIC().longValue() : null);
				
				requestReply.setCorrectedTIROperationTermination(termination);
				reconciliationRequestReplies.getReconciliationRequestReply().add(requestReply);
			}
			reconciliationRequestReplies.setCount((long) reconciliationRequestReplies.getReconciliationRequestReply().size());
			transmitReconciliationRequestReplies(reconciliationRequestReplies, messageID, new Date());
		} catch (Exception e) {
			return ReturnCode.UNCLASSIFIED_ERROR;
		}
		return ReturnCode.SUCCESS;
	}
	
}
