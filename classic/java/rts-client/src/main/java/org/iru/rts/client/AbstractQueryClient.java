package org.iru.rts.client;

import java.io.File;
import java.io.IOException;
import java.security.GeneralSecurityException;
import java.security.cert.CertificateException;
import java.security.cert.X509Certificate;
import java.util.HashMap;
import java.util.Map;

import org.apache.commons.io.FileUtils;
import org.iru.common.crypto.wscrypto.CryptoUtil;
import org.iru.common.crypto.wscrypto.Decrypter;

public class AbstractQueryClient extends AbstractClient {

	private Map<String, byte[]> localCertificateThumbprintsToPrivateKeys;
	
	public void setLocalCertificateToPrivateKeys(Map<File, File> localCertToPrivateKeys) throws IOException, CertificateException {
		this.localCertificateThumbprintsToPrivateKeys = new HashMap<String, byte[]>();
		for (Map.Entry<File, File> ctk : localCertToPrivateKeys.entrySet()) {
			X509Certificate x509 = CryptoUtil.loadCertificate(FileUtils.readFileToByteArray(ctk.getKey()));
			String thumbprint = CryptoUtil.getThumbprint(x509);
			byte[] privKey = FileUtils.readFileToByteArray(ctk.getValue());
			localCertificateThumbprintsToPrivateKeys.put(thumbprint, privKey);
		}
	}

	protected Decrypter getDecrypter(String responseMessageTag) throws GeneralSecurityException, IOException {
		byte[] privateKey = localCertificateThumbprintsToPrivateKeys.get(responseMessageTag.toLowerCase());
		
		if (privateKey == null)
			throw new GeneralSecurityException("Unknown certicate thumbprint: "+responseMessageTag);
		
		Decrypter dec = new Decrypter();
		dec.setPrivateKeyDER(privateKey);
		return dec;
	}
}
