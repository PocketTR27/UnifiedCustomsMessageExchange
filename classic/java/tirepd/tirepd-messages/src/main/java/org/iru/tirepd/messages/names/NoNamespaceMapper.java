package org.iru.tirepd.messages.names;

public class NoNamespaceMapper {
	
	public static Class<?> getB2GClass(String messageName) {
		B2GMessage msg = B2GMessage.valueOf(messageName);
		return msg.payloadClass();
	}
	
	public static String getB2GMessageName(Object message) {
		B2GMessage msg = B2GMessage.fromPayload(message);
		return msg.toString();
	}

	public static Class<?> getG2BClass(String messageName) {
		G2BMessage msg = G2BMessage.valueOf(messageName);
		return msg.payloadClass();
	}
	
	public static String getG2BMessageName(Object message) {
		G2BMessage msg = G2BMessage.fromPayload(message);
		return msg.toString();
	}
}
