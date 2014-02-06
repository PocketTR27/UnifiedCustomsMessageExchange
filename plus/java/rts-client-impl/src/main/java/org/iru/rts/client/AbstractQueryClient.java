package org.iru.rts.client;

import java.io.File;
import java.io.IOException;
import java.security.cert.CertificateException;
import java.util.Map;

public class AbstractQueryClient extends AbstractClient {

	public void setLocalCertificateToPrivateKeys(Map<File, File> localCertToPrivateKeys) throws IOException, CertificateException {
	}

}
