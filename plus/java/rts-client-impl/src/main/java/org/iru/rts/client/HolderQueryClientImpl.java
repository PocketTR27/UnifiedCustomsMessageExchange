package org.iru.rts.client;

import java.io.IOException;
import java.security.GeneralSecurityException;
import java.util.Date;

import javax.xml.bind.JAXBException;
import javax.xml.datatype.DatatypeConfigurationException;

import org.iru.rts.converter.TCHQConverter;
import org.iru.rts.model.carnet_1.CarnetType;
import org.iru.rtsplus.client.CarnetServiceClientImpl;

public class HolderQueryClientImpl extends CarnetServiceClientImpl implements HolderQueryClient {
	
	public static class Response {
	    int result;
	    public int getResult() {
			return result;
		}
		public String getCarnetNumber() {
			return carnetNumber;
		}
		public String getHolderID() {
			return holderID;
		}
		public Date getValidityDate() {
			return validityDate;
		}
		public String getAssociation() {
			return association;
		}
		public Integer getNumTerminations() {
			return numTerminations;
		}
		String carnetNumber;
	    String holderID;
	    Date validityDate;
	    String association;
	    Integer numTerminations;
	}
	
	public HolderQueryResponse queryCarnet(String carnetNumber, String queryID) throws DatatypeConfigurationException, IOException, JAXBException, GeneralSecurityException  {
		return queryCarnet(carnetNumber, queryID, HolderQueryReason.OTHER);
	}
	
	public HolderQueryResponse queryCarnet(String carnetNumber, String queryID, HolderQueryReason reason) throws DatatypeConfigurationException, IOException, JAXBException, GeneralSecurityException  {
		CarnetType carnet = queryCarnet(carnetNumber);
		HolderQueryResponse response = new HolderQueryResponse();
		response.result = TCHQConverter.convertStatusToResult(carnet.getStatus());
		response.carnetNumber = carnet.getTIRCarnetNumber();
		response.holderID = response.holderID = TCHQConverter.convertHolderToID(carnet.getHolder());
		response.validityDate = TCHQConverter.convertToGregorianCalendar(carnet.getExpiryDate());
		response.association = TCHQConverter.convertAssociationToID(carnet.getAssociation());
		response.numTerminations =  TCHQConverter.convertToNumTerminations(carnet.getTIROperationTerminations());
		return response;
	}
	
}
