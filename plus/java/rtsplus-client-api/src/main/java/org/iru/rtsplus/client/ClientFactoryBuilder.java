package org.iru.rtsplus.client;

import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.Reader;
import java.io.StringWriter;

public class ClientFactoryBuilder {

	public static ClientFactory newInstance() {
		ClassLoader contextClassLoader = Thread.currentThread().getContextClassLoader();
		String fname = ClientFactory.class.getName();
		InputStream is = contextClassLoader.getResourceAsStream("META-INF/services/"+fname);
		if (is == null) {
			throw new RuntimeException("No implementation found of "+fname);
		}
		try {
		Reader r = new InputStreamReader(is, "UTF-8");
		StringWriter w = new StringWriter();
		int read;
		while ((read = r.read()) != -1) {
			w.write(read);
		}
		r.close();
		
		Class<ClientFactory> clazz = (Class<ClientFactory>) contextClassLoader.loadClass(w.toString());
		
		return clazz.newInstance();
		} catch (Exception e) {
			RuntimeException ie = new RuntimeException("Unable to instantiate a "+fname);
			ie.initCause(e);
			throw ie;
		}
	}
	
}
