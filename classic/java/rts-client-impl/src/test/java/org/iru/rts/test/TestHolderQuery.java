package org.iru.rts.test;

import java.io.IOException;
import java.security.GeneralSecurityException;
import java.text.SimpleDateFormat;
import java.util.Date;

import javax.xml.bind.JAXBException;
import javax.xml.datatype.DatatypeConfigurationException;

import junit.framework.Assert;

import org.iru.rts.client.HolderQueryClientImpl;
import org.iru.rts.client.HolderQueryResponse;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration(locations = { "classpath:test.xml" })
public class TestHolderQuery {

	@Autowired
	private HolderQueryClientImpl tchq;
	
	public static class Carnet {
		private String number;
		public void setNumber(String number) {
			this.number = number;
		}
		public void setResult(int result) {
			this.result = result;
		}
		private int result;
	}
	
	@Autowired
	private Carnet carnet;
	
		
	@Test
	public void queryInvalidCarnet() throws DatatypeConfigurationException, IOException, JAXBException, GeneralSecurityException {
		
		HolderQueryResponse response = tchq.queryCarnet(carnet.number, new SimpleDateFormat("yyyyMMddHHmmssZ").format(new Date()));

		Assert.assertEquals(carnet.result, response.getResult());
		Assert.assertEquals(carnet.number, response.getCarnetNumber());
		if (carnet.result == 5) { 
			Assert.assertNull(response.getAssociation());
			Assert.assertNull(response.getHolderID());
			Assert.assertNull(response.getNumTerminations());
			Assert.assertNull(response.getValidityDate());
		}
	}
	
}
