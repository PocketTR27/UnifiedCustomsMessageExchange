package org.iru.rts.client.plus.converter;

import java.util.GregorianCalendar;

import javax.xml.datatype.XMLGregorianCalendar;

import org.iru.model.tir_actor_1.Association;
import org.iru.model.tir_actor_1.HaulierType;
import org.iru.rts.model.carnet_1.CarnetStatusType;
import org.iru.rts.model.carnet_1.CarnetType;

public class TCHQConverter {

	public static int convertStatusToResult(CarnetStatusType status) {
		switch (status) {
		case ISSUED_TO_ASSOCIATION:
			return 2;
		case ISSUED_TO_HAULIER:
			return 1;
		case RETURNED_TO_ASSOCIATION:
		case RETURNED_TO_IRU:
			return 4;
		case STOPPED:
			return 3;
		case INCORRECT_NUMBER:
		default:
			return 5;
		}
	}

	public static String convertHolderToID(HaulierType holder) {
		return holder != null ? holder.getId() : null;
	}
	
	public static String convertAssociationToID(Association association) {
		return association != null ? Long.toString(association.getId()) : null;
	}
	
	public static GregorianCalendar convertToGregorianCalendar(XMLGregorianCalendar date) {
		return date != null ? date.toGregorianCalendar() : null;
	}
	
	public static Integer convertToNumTerminations(CarnetType.TIROperationTerminations tirOperationTerminations) {
		return tirOperationTerminations != null ? (int) tirOperationTerminations.getCount() : null;
	}	
}
