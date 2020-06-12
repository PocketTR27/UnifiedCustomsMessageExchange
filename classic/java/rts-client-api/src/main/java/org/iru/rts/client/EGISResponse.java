package org.iru.rts.client;

import java.util.GregorianCalendar;

public class EGISResponse {

	
    private int result;
	private String carnetNumber;
    private String holderID;
    private GregorianCalendar validityDate;
    private String association;
	private Integer numTerminations;
	private String voucherNumber;
	private String requestedGuaranteeNumber;
	private TIROperationMessages tirOperationMessages;
    
    public int getResult() {
		return result;
	}
	public void setResult(int result) {
		this.result = result;
	}
	public String getCarnetNumber() {
		return carnetNumber;
	}
	public void setCarnetNumber(String carnetNumber) {
		this.carnetNumber = carnetNumber;
	}
	public String getHolderID() {
		return holderID;
	}
	public void setHolderID(String holderID) {
		this.holderID = holderID;
	}
	public GregorianCalendar getValidityDate() {
		return validityDate;
	}
	public void setValidityDate(GregorianCalendar validityDate) {
		this.validityDate = validityDate;
	}
	public String getAssociation() {
		return association;
	}
	public void setAssociation(String association) {
		this.association = association;
	}
	public Integer getNumTerminations() {
		return numTerminations;
	}
	public void setNumTerminations(Integer numTerminations) {
		this.numTerminations = numTerminations;
	}

	public String getVoucherNumber() {
		return voucherNumber;
	}

	public void setVoucherNumber(String voucherNumber) {
		this.voucherNumber = voucherNumber;
	}

	public String getRequestedGuaranteeNumber() {
		return requestedGuaranteeNumber;
	}

	public void setRequestedGuaranteeNumber(String requestedGuaranteeNumber) {
		this.requestedGuaranteeNumber = requestedGuaranteeNumber;
	}

	public TIROperationMessages getTIROperationMessages() {
		return tirOperationMessages;
	}

	public void setTIROperationMessages(TIROperationMessages tirOperationMessages) {
		this.tirOperationMessages = tirOperationMessages;
	}

}
