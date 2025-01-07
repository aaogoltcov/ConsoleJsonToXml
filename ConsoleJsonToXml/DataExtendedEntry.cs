using System.Xml.Serialization;

namespace ConsoleJsonToXml;

[XmlType("Data#ExtendedEntry")]
public class DataExtendedEntry : DataEntry
{
    [XmlElement("Data#Extended")] public string? ExtendedName;
}