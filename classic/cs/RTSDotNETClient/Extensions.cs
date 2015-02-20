using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace RTSDotNETClient
{
    public static class ObjectExtension
    {
        public static string Serialize(this object obj)
        {
            XmlSerializer ser = new XmlSerializer(obj.GetType());
            string xml;
            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    ser.Serialize(writer, obj);
                    xml = sw.ToString();
                }
            }
            return xml;
        }
    }
}
