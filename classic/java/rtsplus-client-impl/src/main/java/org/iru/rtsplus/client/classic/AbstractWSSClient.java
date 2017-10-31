package org.iru.rtsplus.client.classic;

import java.io.ByteArrayInputStream;
import java.io.File;
import java.io.IOException;
import java.lang.reflect.UndeclaredThrowableException;
import java.security.cert.CertificateEncodingException;
import java.security.cert.CertificateException;
import java.security.cert.CertificateFactory;
import java.security.cert.X509Certificate;
import java.util.GregorianCalendar;
import java.util.Map;

import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;

import org.apache.commons.codec.digest.DigestUtils;
import org.iru.rts.client.classic.AbstractClient;
import org.iru.rts.client.classic.AbstractQueryClient;

public class AbstractWSSClient extends AbstractQueryClient {

	private File iruCertificateFile;
	private byte[] iruCertificateData;
	private Map<File, File> localCertToPrivateKeys;

	public static X509Certificate loadCertificate(byte[] cert) throws CertificateException {
		CertificateFactory x509CertFact = CertificateFactory.getInstance("X.509");
		ByteArrayInputStream in = new ByteArrayInputStream(cert);
		try {
			return (X509Certificate) x509CertFact.generateCertificate(in);
		} finally {
			try {
				in.close();
			} catch (IOException e) {
				// impossible, so rethrow as CertificateException
				throw new CertificateException(e);
			}
		}
	}
	
	public static String getThumbprint(X509Certificate cert) throws CertificateEncodingException {
		return DigestUtils.sha1Hex(cert.getEncoded());
	}
	
	protected XMLGregorianCalendar convertToXML(GregorianCalendar d) throws DatatypeConfigurationException  {
		if (d == null)
			return null;
		return DatatypeFactory.newInstance().newXMLGregorianCalendar(d);
	}

	@Override
	public void setIruCertificate(File iruCertificate) throws IOException {
		super.setIruCertificate(iruCertificate);
		this.iruCertificateFile = iruCertificate;
	}

	@Override
	public void setIruCertificateData(byte[] iruCertificate) {
		super.setIruCertificateData(iruCertificate);;
		this.iruCertificateData = iruCertificate;
	}

	@Override
	public void setLocalCertificateToPrivateKeys(Map<File, File> localCertToPrivateKeys) throws IOException, CertificateException {
		super.setLocalCertificateToPrivateKeys(localCertToPrivateKeys);
		this.localCertToPrivateKeys = localCertToPrivateKeys;
	}
	
	protected void updateClientSettings(AbstractClient client) {
		client.setSender(sender);
		client.setPassword(password);
		client.setRtsEndpoint(rtsEndpoint);
		try {
			if (iruCertificateFile != null)
				client.setIruCertificate(iruCertificateFile);
			else
				client.setIruCertificateData(iruCertificateData);
		} catch (IOException e) {
			throw new UndeclaredThrowableException(e);
		}
		client.setBindingProviderRequestContext(bindingProviderRequestContext);
		if (client instanceof AbstractQueryClient) {
			AbstractQueryClient qc = (AbstractQueryClient) client;
			try {
				qc.setLocalCertificateToPrivateKeys(localCertToPrivateKeys);
			} catch (Exception e) {
				throw new UndeclaredThrowableException(e);
			}
		}
	}

}
