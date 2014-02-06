package org.iru.rts.test;

import java.io.File;
import java.net.URL;

class FileUtils {

	static File locateFileInClasspath(String filename) {
		URL uf = Thread.currentThread().getContextClassLoader().getResource(filename);
		return new File(uf.getFile());
	}
	
}
