using System.Xml.Serialization;

namespace ConsoleJsonToXml;

[XmlType("Data.Entry")]
public class DataEntry
{
    [XmlAttribute] public string? LinkedEntry;

    [XmlElement("Data.Name")] public string? Name;
}