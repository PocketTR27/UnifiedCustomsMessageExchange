using System.ServiceModel;

namespace B2G
{
    
    [ServiceContract(Namespace="http://www.iru.org", ConfigurationName="ITIREPDB2GService")]
    public interface ITIREPDB2GService
    {        
        [OperationContract(Action="http://www.iru.org/TIREPDB2G")]
        [XmlSerializerFormat(SupportFaults = true)]
        TIREPDB2GUploadAck TIREPDB2G(TIREPDB2GUploadParams su);
    }
}
