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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iru.org/SafeTIRUpload")]
    public class RecordsRecord : WSST.Record
    {
    }
}
