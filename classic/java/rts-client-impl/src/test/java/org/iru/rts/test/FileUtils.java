package org.iru.rts.test;

import java.io.File;
import java.io.IOException;
import java.net.URL;

class FileUtils {

	static File locateFileInClasspath(String filename) {
		URL uf = Thread.currentThread().getContextClassLoader().getResource(filename);
		return new File(uf.getFile());
	}
	
	public static byte[] loadFileInClasspath(String filename) throws IOException {
		return org.apache.commons.io.FileUtils.readFileToByteArray(locateFileInClasspath(filename));
	}
}
