package org.iru.tirepd.messages.names;

import org.iru.epd.message.EPD004;
import org.iru.epd.message.EPD005;
import org.iru.epd.message.EPD009;
import org.iru.epd.message.EPD016;
import org.iru.epd.message.EPD025;
import org.iru.epd.message.EPD028;
import org.iru.epd.message.EPD029;
import org.iru.epd.message.EPD045;
import org.iru.epd.message.EPD051;
import org.iru.epd.message.EPD055;
import org.iru.epd.message.EPD060;
import org.iru.epd.message.EPD140;
import org.iru.epd.message.EPD917;
import org.iru.epd.message.EPD928;

public enum G2BMessage {
	
	TIRPreDeclarationReceived(EPD928.class),
	TIRPreDeclarationError(EPD917.class),
	TIRPreDeclarationAccepted(EPD028.class),
	TIRPreDeclarationRejected(EPD016.class),
	TIRPreDeclarationControlNotification(EPD060.class),
	TIRPreDeclarationGuaranteeProblem(EPD055.class),
	TIRPreDeclarationReleased(EPD029.class),
	TIRPreDeclarationTransitRefused(EPD051.class),
	TIRPreDeclarationCancellationReply(EPD009.class),
	TIRPreDeclarationAmendmentAccepted(EPD004.class),
	TIRPreDeclarationAmendmentRejected(EPD005.class),
	TIRPreDeclarationReqOnNonArrMov(EPD140.class),
	TIRPreDeclarationUpdateSealsNotification(EPD025.class),
	TIRPreDeclarationDischargeNotification(EPD045.class);
	
	private final Class<?> payloadClass;
	
	private G2BMessage(Class<?> payloadClass) {
		this.payloadClass = payloadClass;
	}

	public Class<?> payloadClass() {
		return payloadClass;
	}
	
	public static G2BMessage fromPayload(Object o) {
		Class<?> c = o.getClass();
		for (G2BMessage m : values()) {
			if (c.equals(m.payloadClass))
				return m;
		}
		return null;
	}
}
