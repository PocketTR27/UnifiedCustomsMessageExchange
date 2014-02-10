package org.iru.common.crypto.wscrypto.test;

import java.io.InputStream;

import org.apache.commons.io.IOUtils;
import org.iru.common.crypto.wscrypto.Decrypter;
import org.junit.Test;

public class TestPKeyLoad {


	@Test
	public void loadGenKey() throws Exception {
		InputStream is = Thread.currentThread().getContextClassLoader().getResourceAsStream("RTSJAVA_recv.key.der");
		byte[] kb = IOUtils.toByteArray(is);
		Decrypter dc = new Decrypter();
		dc.setPrivateKeyDER(kb);
	}

}
