package org.iru.rtsplus.client;

import java.lang.reflect.UndeclaredThrowableException;
import java.util.Date;
import java.util.Set;
import java.util.UUID;

import javax.xml.datatype.DatatypeConfigurationException;

import org.iru.model.tir_actor_1.Association;
import org.iru.model.tir_actor_1.HaulierType;
import org.iru.rts.client.AbstractClient;
import org.iru.rts.client.HolderQueryClient;
import org.iru.rts.client.HolderQueryClientImpl;
import org.iru.rts.client.HolderQueryReason;
import org.iru.rts.client.HolderQueryResponse;
import org.iru.rts.model.carnet_1.CarnetStatusType;
import org.iru.rts.model.carnet_1.CarnetType;
import org.iru.rts.model.carnet_1.StoppedCarnetType;

public class CarnetServiceClientImpl extends AbstractWSSClient implements CarnetServiceClient {

	HolderQueryClient tchq;
	boolean tchqSet;

	public void setStoppedCarnetRetrievalRange(Long retrievalRange) {
		throw new UnsupportedOperationException();
	}

	@Override
	public Set<StoppedCarnetType> getStoppedCarnets(Date from, Date to) throws DatatypeConfigurationException {
		throw new UnsupportedOperationException();
	}

	protected HolderQueryClient getTCHQ() {
		return new HolderQueryClientImpl();
	}
	
	@Override
	public CarnetType queryCarnet(String tirCarnetNumber) {
		synchronized (this) {
			if (! tchqSet) {
				try {
					tchq = getTCHQ();
					updateClientSettings((AbstractClient) tchq);
				} finally {
					tchqSet = true;
				}
			}
		}
		try {
			HolderQueryResponse response = tchq.queryCarnet(tirCarnetNumber, UUID.randomUUID().toString(), HolderQueryReason.OTHER);
			CarnetType carnet = new CarnetType();
			carnet.setTIRCarnetNumber(response.getCarnetNumber());
			if (response.getAssociation() != null) {
				Association assoc = new Association();
				long id = Long.parseLong(response.getAssociation());
				assoc.setId(id);
				carnet.setAssociation(assoc);	
			}
			
			if (response.getHolderID() != null) {
				HaulierType holder = new HaulierType();
				holder.setId(response.getHolderID());
				carnet.setHolder(holder);
			}
			
			if (response.getValidityDate() != null) {
				carnet.setExpiryDate(convertToXML(response.getValidityDate()));
			}
			if (response.getNumTerminations() != null) {
				CarnetType.TIROperationTerminations terms = new CarnetType.TIROperationTerminations();
				terms.setCount(response.getNumTerminations().longValue());
				carnet.setTIROperationTerminations(terms);
			}
			CarnetStatusType status;
			switch (response.getResult()) {
			case 1:
				status = CarnetStatusType.ISSUED_TO_HAULIER;
				break;
			case 2:
				status = CarnetStatusType.ISSUED_TO_ASSOCIATION;
				break;
			case 3:
				status = CarnetStatusType.STOPPED;
				break;
			case 4:
				status = CarnetStatusType.RETURNED_TO_ASSOCIATION;
				break;
			case 5:
			default:
				status = CarnetStatusType.INCORRECT_NUMBER;
				break;
			}
			carnet.setStatus(status);
			return carnet;
		} catch (Exception e) {
			if (e instanceof RuntimeException)
				throw (RuntimeException) e;
			throw new UndeclaredThrowableException(e);
		}
	}

}
