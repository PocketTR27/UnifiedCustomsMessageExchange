package org.iru.common.crypto.wscrypto.test;

import java.io.InputStream;

import org.apache.commons.io.IOUtils;
import org.iru.common.crypto.wscrypto.Encrypter;
import org.junit.Assert;
import org.junit.Test;

public class TestCertLoad {

	@Test
	public void loadGenKey() throws Exception {
		InputStream is = Thread.currentThread().getContextClassLoader().getResourceAsStream("RTSJAVA_recv.cer.pem");
		byte[] kb = IOUtils.toByteArray(is);
		Encrypter enc = new Encrypter();
		enc.setCertificate(kb);
		Assert.assertNotNull(enc.getCertificateThumbprint());
		Assert.assertNotSame("", enc.getCertificateThumbprint());
	}
}
