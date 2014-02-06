package org.iru.common.crypto.wscrypto.test;

import java.io.File;
import java.net.URL;

import org.apache.commons.io.FileUtils;
import org.iru.common.crypto.wscrypto.Encrypter;
import org.junit.Assert;
import org.junit.Test;

public class TestCertLoad {

	@Test
	public void loadGenKey() throws Exception {
		URL k = Thread.currentThread().getContextClassLoader().getResource("rtsj1024.crt");
		File kf = new File(k.getFile());
		byte[] kb = FileUtils.readFileToByteArray(kf);
		Encrypter enc = new Encrypter();
		enc.setCertificate(kb);
		Assert.assertNotNull(enc.getCertificateThumbprint());
		Assert.assertNotSame("", enc.getCertificateThumbprint());
	}
}
