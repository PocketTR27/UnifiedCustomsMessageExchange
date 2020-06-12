package org.iru.rts.client;

import java.util.List;

import org.iru.epd.model.message.nons.EPD025;
import org.iru.epd.model.message.nons.EPD029;
import org.iru.epd.model.message.nons.EPD045;
import org.iru.rts.safetirupload.Records;

public class TIROperationMessages {

    private List<EPD029> startMessages;
    private List<Records.Record> terminationAndExitMessages;
    private List<EPD045> dischargeMessages;
    private List<EPD025> updateSealsMessages;

    public List<EPD029> getStartMessages() {
		return startMessages;
	}

	public void setStartMessages(List<EPD029> startMessages) {
		this.startMessages = startMessages;
    }
    
    public List<Records.Record> getTerminationAndExitMessages() {
		return terminationAndExitMessages;
	}

	public void setTerminationAndExitMessages(List<Records.Record> terminationAndExitMessages) {
        this.terminationAndExitMessages = terminationAndExitMessages;
    }
    
    public List<EPD045> getDischargeMessages() {
		return dischargeMessages;
	}

	public void setDischargeMessages(List<EPD045> dischargeMessages) {
		this.dischargeMessages = dischargeMessages;
    }

    public List<EPD025> getUpdateSealsMessages() {
		return updateSealsMessages;
	}

	public void setUpdateSealsMessages(List<EPD025> updateSealsMessages) {
		this.updateSealsMessages = updateSealsMessages;
    }
}