package org.iru.common.crypto.wscrypto;

public class CipheredData {
	
	byte[] sessionKey;
	byte[] payload;
	
	public byte[] getSessionKey() {
		return sessionKey;
	}
	public void setSessionKey(byte[] sessionKey) {
		this.sessionKey = sessionKey;
	}
	public byte[] getPayload() {
		return payload;
	}
	public void setPayload(byte[] payload) {
		this.payload = payload;
	}

	
}
