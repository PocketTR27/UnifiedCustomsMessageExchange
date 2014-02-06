package org.iru.rts.client;

import java.util.GregorianCalendar;

public class HolderQueryResponse {

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
	public GregorianCalendar getValidityDate() {
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
    GregorianCalendar validityDate;
    String association;
    Integer numTerminations;

}
