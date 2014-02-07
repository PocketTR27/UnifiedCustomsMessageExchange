package org.iru.rts.client;

public enum HolderQueryReason {

	ENTRY(1),
	EXIT(2),
	TERMINATION(3),
	OPENING(4),
	OTHER(5);
	
	private int reasonCode;

	HolderQueryReason(int reasonCode) {
		this.reasonCode = reasonCode;
	}
	
	public int codeValue() { 
		return reasonCode; 
	}
	
}
