
using System.Configuration;
using System;
namespace B2G
{

    public class TIREPDB2GUploadAck
    {                       
        public string HostID {get;set;}
        public string SubscriberMessageID { get; set; }
        public int ReturnCode { get; set; }
        public int ReturnCodeReason { get; set; }

        public TIREPDB2GUploadAck() 
        {
            this.HostID = ConfigurationManager.AppSettings["SubscriberID"];
            this.SubscriberMessageID = "";
            this.ReturnCode = (int)AckReturnCode.AnyUnclassifiedError;
            this.ReturnCodeReason = 0;
        }

        public TIREPDB2GUploadAck(AckReturnCode returnCode, string subscriberMessageID) : this()
        {
            this.ReturnCode = (int)returnCode;
            this.SubscriberMessageID = subscriberMessageID;
        }
        
    }
}
