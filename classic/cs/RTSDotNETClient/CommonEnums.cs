using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RTSDotNETClient
{
    /// <summary>
    /// TIR Carnet Operation (optional).
    /// </summary>
    public enum TCO
    {
        /// <summary>
        /// No value is given (not specified)
        /// </summary>
        [XmlIgnore]
        NotSpecified,

        /// <summary>
        /// Before Load TIR operation
        /// </summary>
        [XmlEnum("LOAD")]
        BeforeLoad,

        /// <summary>
        /// Exit TIR operation
        /// </summary>
        [XmlEnum("EXIT")]
        Exit
    }

    /// <summary>
    /// Discharge with or without Reservation. 
    /// </summary>
    public enum CWR
    {
        /// <summary>
        /// Discharge without Reservation
        /// </summary>
        [XmlEnum("OK")]
        OK,

        /// <summary>
        /// Discharge with Reservation
        /// </summary>
        [XmlEnum("R")]
        WithReservation
    }

    /// <summary>
    /// Carnet or volet retained by customs or not 
    /// </summary>
    public enum RBC
    {
        /// <summary>
        /// No value is given (not specified)
        /// </summary>
        [XmlIgnore]
        NotSpecified,

        /// <summary>
        /// Carnet Retained by Customs
        /// </summary>
        [XmlEnum("CR")]
        CarnetRetained,

        /// <summary>
        /// Carnet NOT retained by Customs
        /// </summary>
        [XmlEnum("CNR")]
        CarnetNotRetained,

        /// <summary>
        /// Volet retained by Customs
        /// </summary>
        [XmlEnum("VR")]
        VoletRetained,

        /// <summary>
        /// Volet NOT retained by Customs
        /// </summary>
        [XmlEnum("VNR")]
        VoletNotRetained
    }
}
