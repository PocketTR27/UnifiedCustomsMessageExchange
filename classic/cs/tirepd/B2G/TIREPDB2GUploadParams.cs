
namespace B2G
{

    public class TIREPDB2GUploadParams
    {                
        public string SubscriberID { get; set; }
        public string CertificateID { get; set; }
        public byte[] ESessionKey { get; set; }
        public string SubscriberMessageID { get; set; }
        public string InformationExchangeVersion { get; set; }
        public string MessageName { get; set; }
        public string TimeSent { get; set; }
        public byte[] MessageContent  { get; set; }
    }
}
