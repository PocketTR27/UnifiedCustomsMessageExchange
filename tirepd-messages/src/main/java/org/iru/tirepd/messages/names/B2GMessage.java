package org.iru.tirepd.messages.names;

import org.iru.epd.message.EPD013;
import org.iru.epd.message.EPD014;
import org.iru.epd.message.EPD015;
import org.iru.epd.message.EPD141;

public enum B2GMessage {

	TIRPreDeclaration(EPD015.class),
	TIRPreDeclarationCancellationNotice(EPD014.class),
	TIRPreDeclarationAmendment(EPD013.class),
	TIRPreDeclarationInfOnNonArrMov(EPD141.class);

	private final Class<?> payloadClass;
	
	private B2GMessage(Class<?> payloadClass) {
		this.payloadClass = payloadClass;
	}
	
	public Class<?> payloadClass() {
		return payloadClass;
	}
	
	public static B2GMessage fromPayload(Object o) {
		Class<?> c = o.getClass();
		for (B2GMessage m : values()) {
			if (c.equals(m.payloadClass))
				return m;
		}
		return null;
	}
	
}
