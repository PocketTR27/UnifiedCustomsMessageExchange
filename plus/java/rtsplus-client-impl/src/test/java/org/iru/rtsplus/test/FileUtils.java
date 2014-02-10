package org.iru.rtsplus.test;

import java.io.IOException;
import java.io.InputStream;

import org.apache.commons.io.IOUtils;

class FileUtils {

	public static byte[] loadFileInClasspath(String filename) throws IOException {
		InputStream is = Thread.currentThread().getContextClassLoader().getResourceAsStream(filename);
		return IOUtils.toByteArray(is);
	}
	
}
