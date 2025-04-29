using System.Xml.Serialization;

namespace ConsoleJsonToXml;

[XmlRoot("Data.Root")]
public class DataRoot
{
    [XmlArray("Data.Root.Names")] [XmlArrayItem("Name")]
    public string[]? Names;

    [XmlElement("Data.Entry")] public DataEntry? Entry;

    [XmlElement("Data#ExtendedEntry")] public DataExtendedEntry? ExtendedEntry;
}