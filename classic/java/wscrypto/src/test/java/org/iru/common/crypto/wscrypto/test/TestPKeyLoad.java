package org.iru.common.crypto.wscrypto.test;

import java.io.File;
import java.net.URL;

import org.apache.commons.io.FileUtils;
import org.iru.common.crypto.wscrypto.Decrypter;
import org.junit.Test;

public class TestPKeyLoad {


	@Test
	public void loadGenKey() throws Exception {
		URL k = Thread.currentThread().getContextClassLoader().getResource("rtsj1024.der");
		File kf = new File(k.getFile());
		byte[] kb = FileUtils.readFileToByteArray(kf);
		Decrypter dc = new Decrypter();
		dc.setPrivateKeyDER(kb);
	}

}
