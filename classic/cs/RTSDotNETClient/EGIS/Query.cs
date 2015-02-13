using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Generic;

using RTSDotNETClient;

namespace RTSDotNETClient.EGIS
{
    /// <summary>
    /// The Electronic Guarantee Information Query to be sent to the EGIS Web Service
    /// </summary>
    [XmlRoot("EGISQuery", Namespace = "http://rts.iru.org/egis")]
    public class EGISQuery : BaseQueryResponse
    {
        /// <summary>
        /// The xml schema definition file that defines the structure of the query
        /// </summary>
        public const string Xsd = "EGIS.xsd";

        /// <summary>
        /// The body of the query
        /// </summary>
        [XmlElement("Body", Namespace = "http://rts.iru.org/egis")]
        public TCHQ.Body<QueryType> Body = new TCHQ.Body<QueryType>();

        /// <summary>
        /// The default constructor
        /// </summary>
        public EGISQuery()
        {
            this.xsd = Xsd;
            this.extraTypes.Clear();
            this.extraTypes.Add(typeof(EGISEnvelope));
            this.Envelope = new EGISEnvelope();
        }
    }

    /// <summary>
    /// Type of the query
    /// </summary>
    [Flags]
    public enum QueryType
    {
        /// <summary>
        /// Carnet Holder
        /// </summary>
        [XmlEnum("1")]
        StandardElectronicGuaranteeInformation = 1
    }

    /// <summary>
    /// The envelope of queries or responses
    /// </summary>
    [XmlRoot("Envelope", Namespace = "http://rts.iru.org/egis")]
    public class EGISEnvelope: Envelope
    {
        #region IXmlSerializable Members

        /// <summary>
        /// Converts an object into its XML representation. It implements IXmlSerializable.
        /// </summary>
        /// <param name="writer">The XmlWriter stream to which the object is serialized.</param>
        override public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Hash", "http://www.iru.org/TCHQuery", Hash);
        }

        #endregion
    }
}
