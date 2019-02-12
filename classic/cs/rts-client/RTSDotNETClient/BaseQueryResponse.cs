using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RTSDotNETClient
{
    /// <summary>
    /// The envelope of queries or responses
    /// </summary>
    public class Envelope: IXmlSerializable
    {
        internal string _RebuiltHash = String.Empty;

        /// <summary>
        /// Namespace of the Hash. It can be null to indicate same namespace then the Envelope.
        /// </summary>
        public string NamespaceOfHash { get; set; }

        /// <summary>
        /// The hash of the query / response body
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// The hash value rebuilt with a returned response body
        /// </summary>
        [XmlIgnore()]
        public string RebuiltHash
        {
            get
            {
                return _RebuiltHash; 
            }
        }

        #region IXmlSerializable Members

        /// <summary>
        /// This method is reserved and should not be used. It implements IXmlSerializable.
        /// </summary>
        /// <returns>null</returns>
        virtual public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Generates an object from its XML representation. It implements IXmlSerializable.
        /// </summary>
        /// <param name="reader">The XmlReader stream from which the object is deserialized.</param>
        virtual public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement();
            reader.MoveToContent();
            if (!reader.IsEmptyElement)
            {
                if (reader.LocalName == "Hash")
                {
                    NamespaceOfHash = reader.NamespaceURI;
                    Hash = reader.ReadElementString();
                }
                else
                {
                    throw new XmlException("Hash element expected");
                }
            }
            reader.ReadEndElement();
        }

        /// <summary>
        /// Converts an object into its XML representation. It implements IXmlSerializable.
        /// </summary>
        /// <param name="writer">The XmlWriter stream to which the object is serialized.</param>
        virtual public void WriteXml(XmlWriter writer)
        {
            if (NamespaceOfHash != null)
            {
                writer.WriteElementString("Hash", NamespaceOfHash, Hash);
            }
            else
            {
                writer.WriteElementString("Hash", Hash);
            }
        }

        #endregion
    }

    /// <summary>
    /// The base class for web service queries and responses
    /// </summary>
    public class BaseQueryResponse
    {        
        /// <summary>
        /// The xml schema definition file that defines the structure of the query or response
        /// </summary>
        protected string xsd;

        /// <summary>
        /// The envelope of the query of response
        /// </summary>
        public Envelope Envelope { get; set; }

        /// <summary>
        /// The default constructor
        /// </summary>
        public BaseQueryResponse()
        {
            this.Envelope = new Envelope();
        }

        /// <summary>
        /// Calculates the hash of the query / response body and stores it in the property Envelope.Hash
        /// </summary>
        public void CalculateHash()
        {
            if (this.Envelope.Hash == null)
                this.Envelope.Hash = "";
            string xml = this.Serialize();

            Match m = Regex.Match(xml, @"<([^:]+:){0,1}Body[^>]*>(.*)<[^/]*/.*Body\s*>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            if (m.Success)
            {
                //string sBodyToSign = Regex.Replace(m.Groups[2].Value.Trim(), @"\s+", "");
                string sBodyToSign = m.Groups[2].Value;
                this.Envelope.Hash = EncryptionHelper.GenerateHash(sBodyToSign);
            }
            else
                throw new Exception("Body not found!");
        }

        public void RebuildHash(string xml)
        {
            Match m = Regex.Match(xml, @"<([^:]+:){0,1}Body[^>]*>(.*)<[^/]*/.*Body\s*>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            if (m.Success)
            {
                //string sBodyToSign = Regex.Replace(m.Groups[2].Value.Trim(), @"\s+", "");
                string sBodyToSign = m.Groups[2].Value;
                this.Envelope._RebuiltHash = EncryptionHelper.GenerateHash(sBodyToSign);
            }
            else
                throw new Exception("Body not found within XML content!");
        }

        /// <summary>
        /// Serialize the query or response
        /// </summary>
        /// <returns></returns>
        public string Serialize()
        {
            XmlSerializer ser = new XmlSerializer(this.GetType());
            string xml;
            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    ser.Serialize(writer, this);
                    xml = sw.ToString();
                }
            }

            if (!Global.XsdValidationDisabled)
            {
                try
                {
                    XmlReaderSettings config = new XmlReaderSettings();
                    config.ValidationType = ValidationType.Schema;
                    config.ValidationEventHandler += new ValidationEventHandler(delegate(object sender, ValidationEventArgs vea)
                    {
                        if (vea.Severity == XmlSeverityType.Error)
                            throw new Exception(vea.Message);
                    });
                    Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Assembly.GetExecutingAssembly().GetName().Name + ".resources." + xsd);
                    config.Schemas.Add(null, XmlReader.Create(stream));
                    List<string> lsSchemasAdded = new List<string>();
                    lsSchemasAdded.Add(xsd);
                    bool bSchemaAdded = true;
                    while (bSchemaAdded)
                    {
                        bSchemaAdded = false;
                        foreach (XmlSchema schema in config.Schemas.Schemas().OfType<XmlSchema>().ToList())
                        {
                            foreach (XmlSchemaExternal external in schema.Includes.OfType<XmlSchemaExternal>().ToList())
                            {
                                if (!lsSchemasAdded.Contains(external.SchemaLocation))
                                {
                                    lsSchemasAdded.Add(external.SchemaLocation);
                                    stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Assembly.GetExecutingAssembly().GetName().Name + ".resources." + external.SchemaLocation);
                                    if (stream != null)
                                    {
                                        config.Schemas.Add(null, XmlReader.Create(stream));
                                        bSchemaAdded = true;
                                    }
                                }
                            }
                        }
                    }

                    StringReader sr = new StringReader(xml);
                    XmlReader reader = XmlReader.Create(sr, config);
                    while (reader.Read())
                    { }
                }
                catch (Exception ex)
                {
                    string err = ex.Message;
                    if (ex.InnerException != null)
                        err += " " + ex.InnerException.Message;
                    throw new XsdValidationException(err, ex);
                }
            }
            return xml;
        }
    }
}
