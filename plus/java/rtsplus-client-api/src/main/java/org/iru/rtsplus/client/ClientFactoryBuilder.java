package org.iru.rtsplus.client;

import java.util.Iterator;
import java.util.ServiceLoader;

public class ClientFactoryBuilder {

	public static ClientFactory newInstance() {
		ServiceLoader<ClientFactory> serviceLoader = ServiceLoader.load(ClientFactory.class);
		Iterator<ClientFactory> iter = serviceLoader.iterator();
		if (iter.hasNext()) {
			return iter.next();
		} else {
			throw new RuntimeException("No implementation found of "+ClientFactory.class.getName());
		}
	}

}
