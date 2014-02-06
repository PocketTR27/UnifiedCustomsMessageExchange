package org.iru.rts.converter;

public class WSREConverter {

	public static String convertRequestReplyToReplyType(int requestReplyType) {
		switch (requestReplyType) {
		case 1:
			return "CONFIRMED";
		case 2:
			return "CORRECTED";
		case 3:
		default:
			return "NOT_FOUND";
		}
	}

}
