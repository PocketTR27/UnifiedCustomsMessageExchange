package org.iru.common.crypto.wscrypto;

import java.io.StringWriter;
import java.security.GeneralSecurityException;
import java.security.cert.CertificateException;
import java.security.cert.X509Certificate;
import java.util.regex.Matcher;

import javax.crypto.Cipher;
import javax.crypto.KeyGenerator;
import javax.crypto.SecretKey;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

import org.apache.commons.codec.digest.DigestUtils;
import org.apache.commons.jxpath.JXPathContext;
import org.apache.commons.jxpath.JXPathException;

public class Encrypter {

	
	private X509Certificate cert;
	private String certThumbprint;

	public void setCertificate(byte[] x509Certificate) throws CertificateException {		
        cert = CryptoUtil.loadCertificate(x509Certificate);
        certThumbprint = CryptoUtil.getThumbprint(cert);
	}
	
	public String getCertificateThumbprint() {
		return certThumbprint;
	}
	
	private byte[] getUnicodeBytes(Object obj) throws JAXBException {
		JAXBContext context = JAXBContext.newInstance(obj.getClass());
		Marshaller m = context.createMarshaller();
		m.setProperty(Marshaller.JAXB_ENCODING, CryptoUtil.UNICODE_CHARSET.displayName());
		m.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
		m.setProperty(Marshaller.JAXB_FRAGMENT, true);
		StringWriter sw = new StringWriter();
		m.marshal(obj, sw);
		
		boolean withHash = true;
		JXPathContext jxpc = JXPathContext.newContext(obj);
		try {
			jxpc.getValue(CryptoUtil.ENVELOPE_HASH_JXPATH);
		} catch (JXPathException e) {
			withHash = false;
		}
		if (withHash) {
			String s = sw.toString();

			Matcher pm = CryptoUtil.BODY_REGEX.matcher(s);
			if (! pm.matches())
				new IllegalArgumentException();
			byte[] hash = DigestUtils.sha1(pm.group(CryptoUtil.BODY_GROUP).getBytes(CryptoUtil.UNICODE_CHARSET));
			jxpc.setValue(CryptoUtil.ENVELOPE_HASH_JXPATH, hash);		
			sw = new StringWriter();
			m.marshal(obj, sw);
		}
		return sw.toString().getBytes(CryptoUtil.UNICODE_CHARSET);
	}

	public CipheredData cryptPayload(Object payload) throws JAXBException, GeneralSecurityException {
		byte[] p;
		if (payload instanceof byte[]) {
			p = (byte[]) payload;
		} else if (payload instanceof String) {
			p = ((String) payload).getBytes(CryptoUtil.UNICODE_CHARSET);
		} else {
			p = getUnicodeBytes(payload);
		}
		
		KeyGenerator keygen = KeyGenerator.getInstance(CryptoUtil.TRIPLE_DES_ALGO);
	    SecretKey sessionKey = keygen.generateKey();
	
	    Cipher cipher = Cipher.getInstance(CryptoUtil.TRIPLE_DES_CIPHER);
	    cipher.init(Cipher.ENCRYPT_MODE, sessionKey, CryptoUtil.IV_SPEC);
	    
	    CipheredData d = new CipheredData();
	    d.setPayload(cipher.doFinal(p));

	    Cipher rsaCipher = Cipher.getInstance(CryptoUtil.RSA_CIPHER);
	    rsaCipher.init(Cipher.WRAP_MODE, cert);
	    d.setSessionKey(rsaCipher.wrap(sessionKey));
	    
	    return d;
	}

	
}
