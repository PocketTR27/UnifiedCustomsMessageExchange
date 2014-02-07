package org.iru.rts.client.plus.converter;

import org.iru.rts.model.termination_1.ReconciliationRequestReasonType;

public class WSRQConverter {
	
	public static int convertReasonToRequestDataSource(ReconciliationRequestReasonType reason) {
		switch (reason) {
		case MISSING:
			return 1; // carnet data
		case DISCREPANCY:
		default:
			return 0; // SafeTIR data
		}
	}
}
