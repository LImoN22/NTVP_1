using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ClassLibrary1
{
    /// <summary>
    /// клас интерфейса IXmlSerializable, серализация и десериализаци листа
    /// </summary>
    class ListOfIMathCount : List<IMathCount>, IXmlSerializable
    {
        
       
            /// <summary>
            /// Конструктор класса
            /// </summary>
        public ListOfIMathCount() : base() { }
            /// <summary>
            /// ыыыыы
            /// </summary>
            /// <returns></returns>
            public XmlSchema GetSchema()
            {
                return null;
            }
            /// <summary>
            /// Десерализаця
            /// </summary>
            /// <param name="reader"></param>
            public void ReadXml(XmlReader reader)
            {
                try
                {
                    reader.ReadStartElement("ListOfResistanceMath");
                    while (reader.IsStartElement("IMathCount"))
                    {
                        Type type = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"));
                        XmlSerializer serial = new XmlSerializer(type);
                        reader.ReadStartElement("IMathCount");
                        this.Add((IMathCount)serial.Deserialize(reader));
                        reader.ReadEndElement();
                    }
                    reader.ReadEndElement();
                }
                catch (Exception) { }

            }
            /// <summary>
            /// Серализация
            /// </summary>
            /// <param name="writer"></param>
            public void WriteXml(XmlWriter writer)
            {
                try
                {
                    foreach (IMathCount resistanceCalc in this)
                    {
                        writer.WriteStartElement("IMathCount");
                        writer.WriteAttributeString("AssemblyQualifiedName", resistanceCalc.GetType().AssemblyQualifiedName);
                        XmlSerializer xmlSerializer = new XmlSerializer(resistanceCalc.GetType());
                        xmlSerializer.Serialize(writer, resistanceCalc);
                        writer.WriteEndElement();
                    }
                }
                catch (Exception) { }


            }
        }
    }

