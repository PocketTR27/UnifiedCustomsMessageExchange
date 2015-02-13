using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Generic;

namespace RTSDotNETClient.EGIS
{
    /// <summary>
    /// The status of the carnet
    /// </summary>
    public enum ResponseResult
    {
        /// <summary>
        /// Issue Data Available
        /// </summary>
        [XmlEnum("1")]
        IssueDataAvailable = 1,

        /// <summary>
        /// No Issue Data Available
        /// </summary>
        [XmlEnum("2")]
        NoIssueDataAvailable = 2,

        /// <summary>
        /// Carnet has been invalidated by the IRU
        /// </summary>
        [XmlEnum("3")]
        CarnetHasBeenInvalidatedByTheIRU = 3,

        /// <summary>
        /// Carnet is not in circulation
        /// </summary>
        [XmlEnum("4")]
        CarnetIsNotInCirculation = 4,

        /// <summary>
        /// Carnet number is incorrect
        /// </summary>
        [XmlEnum("5")]
        CarnetNumberIsIncorrect = 5
    }

    /// <summary>
    /// The response returned by the EGIS Web Service
    /// </summary>
    [XmlRoot("EGISResponse", Namespace = "http://rts.iru.org/egis")]
    public class EGISResponse : BaseQueryResponse
    {
        /// <summary>
        /// The xml schema definition file that defines the structure of the response
        /// </summary>
        public const string Xsd = "EGIS.xsd";

        /// <summary>
        /// The response body
        /// </summary>
        public ResponseBodyType Body = new ResponseBodyType();

        /// <summary>
        /// The default constructor
        /// </summary>
        public EGISResponse()
        {
            this.xsd = Xsd;
            this.extraTypes.Clear();
            this.extraTypes.Add(typeof(EGISEnvelope));
            this.Envelope = new EGISEnvelope();
        }
    }

    public partial class ResponseBodyType : TCHQ.ResponseBody
    {
        private string requestedGuaranteeNumberField;

        private TIROperationMessagesType tIROperationMessagesField;

        public ResponseBodyType()
        {
            this.tIROperationMessagesField = new TIROperationMessagesType();
        }

        public string RequestedGuaranteeNumber
        {
            get
            {
                return this.requestedGuaranteeNumberField;
            }
            set
            {
                this.requestedGuaranteeNumberField = value;
            }
        }

        public TIROperationMessagesType TIROperationMessages
        {
            get
            {
                return this.tIROperationMessagesField;
            }
            set
            {
                this.tIROperationMessagesField = value;
            }
        }
    }

    /*
    [XmlIncludeAttribute(typeof(ResponseBodyType))]
    public partial class BodyType
    {

        private string senderField;

        private string originatorField;

        private System.DateTime responseTimeField;

        private ResponseResult resultField;

        private string carnet_NumberField;

        private string holderIDField;

        private System.DateTime validityDateField;

        private bool validityDateFieldSpecified;

        private string associationField;

        private string numTerminationsField;

        private string voucher_NumberField;

        public BodyType()
        {
            this.senderField = "IRU";
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public string Originator
        {
            get
            {
                return this.originatorField;
            }
            set
            {
                this.originatorField = value;
            }
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public System.DateTime ResponseTime
        {
            get
            {
                return this.responseTimeField;
            }
            set
            {
                this.responseTimeField = value;
            }
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public ResponseResult Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public string Carnet_Number
        {
            get
            {
                return this.carnet_NumberField;
            }
            set
            {
                this.carnet_NumberField = value;
            }
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public string HolderID
        {
            get
            {
                return this.holderIDField;
            }
            set
            {
                this.holderIDField = value;
            }
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public System.DateTime ValidityDate
        {
            get
            {
                return this.validityDateField;
            }
            set
            {
                this.validityDateField = value;
            }
        }

        [XmlIgnoreAttribute()]
        public bool ValidityDateSpecified
        {
            get
            {
                return this.validityDateFieldSpecified;
            }
            set
            {
                this.validityDateFieldSpecified = value;
            }
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public string Association
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public string NumTerminations
        {
            get
            {
                return this.numTerminationsField;
            }
            set
            {
                this.numTerminationsField = value;
            }
        }

        [XmlElement(Namespace = "http://www.iru.org/TCHQResponse")]
        public string Voucher_Number
        {
            get
            {
                return this.voucher_NumberField;
            }
            set
            {
                this.voucher_NumberField = value;
            }
        }
    }
    */

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://rts.iru.org/egis")]
    public partial class TIROperationMessagesType
    {

        private List<EPD029> startMessagesField;

        private List<RecordsRecord> terminationAndExitMessagesField;

        private List<EPD045> dischargeMessagesField;

        private List<EPD025> updateSealsMessagesField;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartMessagesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EPD029", Namespace = "", IsNullable = false)]
        public List<EPD029> StartMessages
        {
            get
            {
                return this.startMessagesField;
            }
            set
            {
                this.startMessagesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TerminationAndExitMessagesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Record", Namespace = "http://www.iru.org/SafeTIRUpload", IsNullable = false)]
        public List<RecordsRecord> TerminationAndExitMessages
        {
            get
            {
                return this.terminationAndExitMessagesField;
            }
            set
            {
                this.terminationAndExitMessagesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DischargeMessagesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EPD045", Namespace = "", IsNullable = false)]
        public List<EPD045> DischargeMessages
        {
            get
            {
                return this.dischargeMessagesField;
            }
            set
            {
                this.dischargeMessagesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateSealsMessagesSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EPD025", Namespace = "", IsNullable = false)]
        public List<EPD025> UpdateSealsMessages
        {
            get
            {
                return this.updateSealsMessagesField;
            }
            set
            {
                this.updateSealsMessagesField = value;
            }
        }
    }
}
