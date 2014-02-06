package org.iru.rtsplus.client;

import java.util.Date;
import java.util.Set;

import javax.xml.datatype.DatatypeConfigurationException;

import org.iru.rts.model.carnet_1.CarnetType;
import org.iru.rts.model.carnet_1.StoppedCarnetType;

public interface CarnetServiceClient {

	public CarnetType queryCarnet(String tirCarnetNumber);
	
	public Set<StoppedCarnetType> getStoppedCarnets(Date from, Date to) throws DatatypeConfigurationException;
}
