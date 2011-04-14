package org.iru.tirepd.messages.names;

import org.apache.commons.collections.BidiMap;
import org.apache.commons.collections.bidimap.DualHashBidiMap;
import org.iru.tirepd.messages.nons.EPD004;
import org.iru.tirepd.messages.nons.EPD005;
import org.iru.tirepd.messages.nons.EPD009;
import org.iru.tirepd.messages.nons.EPD013;
import org.iru.tirepd.messages.nons.EPD014;
import org.iru.tirepd.messages.nons.EPD015;
import org.iru.tirepd.messages.nons.EPD016;
import org.iru.tirepd.messages.nons.EPD028;
import org.iru.tirepd.messages.nons.EPD029;
import org.iru.tirepd.messages.nons.EPD051;
import org.iru.tirepd.messages.nons.EPD055;
import org.iru.tirepd.messages.nons.EPD060;
import org.iru.tirepd.messages.nons.EPD917;
import org.iru.tirepd.messages.nons.EPD928;

public class NoNamespaceMapper {
	
	private static BidiMap b2gNameToClass = new DualHashBidiMap();
	static {
		b2gNameToClass.put(B2GMessage.TIRPreDeclaration, EPD015.class);
		b2gNameToClass.put(B2GMessage.TIRPreDeclarationAmendment, EPD014.class);
		b2gNameToClass.put(B2GMessage.TIRPreDeclarationCancellation, EPD013.class);	
	}

	private static BidiMap g2bNameToClass = new DualHashBidiMap();
	static {
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationReceived, EPD928.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationError, EPD917.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationAccepted, EPD028.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationRejected, EPD016.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationControlNotification, EPD060.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationGuaranteeProblem, EPD055.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationReleased, EPD029.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationTransitRefused, EPD051.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationCancellationReply, EPD009.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationAmendmentAccepted, EPD004.class);
		g2bNameToClass.put(G2BMessage.TIRPreDeclarationAmendmentRejected, EPD005.class);
	}

	public static Class<?> getB2GClass(String messageName) {
		B2GMessage msg = B2GMessage.valueOf(messageName);
		return (Class<?>) b2gNameToClass.get(msg);
	}
	
	public static String getB2GMessageName(Object message) {
		B2GMessage msg = (B2GMessage) b2gNameToClass.inverseBidiMap().get(message.getClass());
		return msg.toString();
	}

	public static Class<?> getG2BClass(String messageName) {
		G2BMessage msg = G2BMessage.valueOf(messageName);
		return (Class<?>) g2bNameToClass.get(msg);
	}
	
	public static String getG2BMessageName(Object message) {
		G2BMessage msg = (G2BMessage) g2bNameToClass.inverseBidiMap().get(message.getClass());
		return msg.toString();
	}
}
