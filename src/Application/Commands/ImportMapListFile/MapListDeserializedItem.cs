using System.Xml.Serialization;

namespace Application.Commands.ImportMapListFile
{
    [XmlRoot(ElementName = "MapList")]
    public class MapList
    {

        [XmlElement(ElementName = "DefaultMaps")]
        public DefaultMaps DefaultMaps { get; set; }
    }

    [XmlRoot(ElementName = "DefaultMaps")]
    public class DefaultMaps
    {

        [XmlElement(ElementName = "Map")]
        public List<MapItem> Maps { get; set; }
    }

    [XmlRoot(ElementName = "Map")]
    public class MapItem
    {

        [XmlAttribute(AttributeName = "Number")]
        public int Number { get; set; }

        [XmlAttribute(AttributeName = "File")]
        public string Name { get; set; }
    }
}