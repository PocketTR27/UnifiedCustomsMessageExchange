package org.iru.tirepd.ws.g2b.client;

import java.security.GeneralSecurityException;

import javax.xml.bind.JAXBException;
import javax.xml.datatype.DatatypeConfigurationException;

import org.iru.tirepd.messages.names.NoNamespaceMapper;

public class NoNSG2BClient extends G2BClient {

	public int upload(String messageID, Object payload) throws JAXBException, GeneralSecurityException, DatatypeConfigurationException {
		String messageName = NoNamespaceMapper.getG2BMessageName(payload);
		return super.upload(messageID, messageName, payload);
	}
	
}
