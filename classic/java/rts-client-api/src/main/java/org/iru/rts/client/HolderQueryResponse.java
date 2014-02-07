package org.iru.rts.client;

import java.util.GregorianCalendar;

public class HolderQueryResponse {

	
    private int result;
	private String carnetNumber;
    private String holderID;
    private GregorianCalendar validityDate;
    private String association;
    private Integer numTerminations;
    
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


}
