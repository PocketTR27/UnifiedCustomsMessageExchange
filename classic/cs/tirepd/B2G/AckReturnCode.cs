using System.Xml.Serialization;

namespace B2G
{

    public enum AckReturnCode
    {
        [XmlEnum("2")]
        Success = 2,
        [XmlEnum("1200")]
        AnyUnclassifiedError = 1200,
        [XmlEnum("1210")]
        MissingOrInvalidSubscriberID = 1210,
        [XmlEnum("1211")]
        MissingOrInvalidCertificateID = 1211,
        [XmlEnum("1213")]
        MissingOrInvalidESessionKey = 1213,
        [XmlEnum("1214")]
        MissingOrInvalidSubscriberMessageID = 1214,
        [XmlEnum("1215")]
        MissingOrInvalidInformationExchangeVersion = 1215,
        [XmlEnum("1216")]
        MissingOrInvalidMessageName = 1216,
        [XmlEnum("1217")]
        MissingOrInvalidTimeSent = 1217,
        [XmlEnum("1218")]
        MissingOrInvalidMessageContents = 1218,
        [XmlEnum("1301")]
        EncryptionDecryptionFailure = 1301,
        [XmlEnum("1302")]
        SchemaValidation = 1302
    }

}
