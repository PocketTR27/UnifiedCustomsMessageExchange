using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RTSDotNETClient.Types
{
    /// <summary>
    /// This is a XML serializable class with DateTimeOffset value.
    /// </summary>
    public class SerializableDateTimeOffset: IXmlSerializable
    {
        private DateTimeOffset innerValue;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SerializableDateTimeOffset()
        {
            this.Value = DateTimeOffset.MinValue;
        }

        /// <summary>
        /// Constructor with initial value.
        /// </summary>
        /// <param name="initialValue">The initial DateTimeOffset value</param>
        public SerializableDateTimeOffset(DateTimeOffset initialValue)
        {
            this.Value = initialValue;
        }

        /// <summary>
        /// Get/set the DateTimeOffset value
        /// </summary>
        [XmlIgnore()]
        public DateTimeOffset Value
        {
            get
            {
                return this.innerValue;
            }

            set
            {
                this.innerValue = value;
            }
        }

        /// <summary>
        /// Implicit conversion from SerializableDateTimeOffset Tyoe to DateTimeOffset C# Type.
        /// </summary>
        /// <param name="serValue">A SerializableDateTimeOffset instance</param>
        /// <returns>The inner value as DateTimeOffset</returns>
        public static implicit operator DateTimeOffset(SerializableDateTimeOffset serValue)
        {
            return serValue.Value;
        }

        /// <summary>
        /// Implicit conversion from DateTimeOffset C# Type to SerializableDateTimeOffset Type.
        /// </summary>
        /// <param name="value">A DateTimeOffset value</param>
        /// <returns>A new instance of SerializableDateTimeOffset with the given DateTimeOffset as inner value</returns>
        public static implicit operator SerializableDateTimeOffset(DateTimeOffset value)
        {
            return new SerializableDateTimeOffset(value);
        }

        /// <summary>
        /// Get the string representation of the DateTimeOffset value.
        /// </summary>
        /// <returns>DateTimeOffset value as string</returns>
        public override string ToString()
        {
            string stringValue = innerValue.ToString("O");

            if (TimeSpan.Compare(TimeSpan.Zero, innerValue.Offset) == 0)
            {
                return stringValue.Substring(0, 10);
            }
            else
            {
                return stringValue.Substring(0, 10) + stringValue.Substring(27, 6);
            }
        }

        #region IXmlSerializable Members

        System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        void IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
        {
            reader.ReadStartElement();
            string valDateWithOffset = reader.Value;
            reader.Skip();
            reader.ReadEndElement();
            if (!String.IsNullOrEmpty(valDateWithOffset))
            {
                System.Globalization.DateTimeStyles dateTimeStyle;
                if (valDateWithOffset.Length > 10)
                {
                    dateTimeStyle = System.Globalization.DateTimeStyles.None;
                }
                else
                {
                    dateTimeStyle = System.Globalization.DateTimeStyles.AssumeUniversal;
                }
                this.Value = DateTimeOffset.Parse(valDateWithOffset, System.Globalization.CultureInfo.InvariantCulture, dateTimeStyle);
            }
        }

        void IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteString(this.ToString());
        }

        #endregion
    }
}
