using System.Xml.Serialization;

namespace Application.Commands.ImportMapDropFile
{
    [XmlRoot(ElementName = "MonsterMapItemDrop")]
    public class MapDropDeserializedItem
    {

        [XmlElement(ElementName = "DropItem")]
        public List<DeserializedItemDrop> ItemDrop { get; set; }
    }

    [XmlRoot(ElementName = "DropItem")]
    public class DeserializedItemDrop
    {

        [XmlAttribute(AttributeName = "MonsterID")]
        public int MonsterID { get; set; }

        [XmlAttribute(AttributeName = "MonsterElement")]
        public int MonsterElement { get; set; }

        [XmlAttribute(AttributeName = "PlayerMinLevel")]
        public int PlayerMinLevel { get; set; }

        [XmlAttribute(AttributeName = "PlayerMaxLevel")]
        public int PlayerMaxLevel { get; set; }

        [XmlAttribute(AttributeName = "Cat")]
        public int Cat { get; set; }

        [XmlAttribute(AttributeName = "Index")]
        public int Index { get; set; }

        [XmlAttribute(AttributeName = "MinLevel")]
        public int MinLevel { get; set; }

        [XmlAttribute(AttributeName = "MaxLevel")]
        public int MaxLevel { get; set; }

        [XmlAttribute(AttributeName = "Durability")]
        public int Durability { get; set; }

        [XmlAttribute(AttributeName = "Skill")]
        public int Skill { get; set; }

        [XmlAttribute(AttributeName = "Luck")]
        public int Luck { get; set; }

        [XmlAttribute(AttributeName = "Option")]
        public int Option { get; set; }

        [XmlAttribute(AttributeName = "Exc")]
        public int Exc { get; set; }

        [XmlAttribute(AttributeName = "Element")]
        public int Element { get; set; }

        [XmlAttribute(AttributeName = "SocketCount")]
        public string SocketCount { get; set; }

        [XmlAttribute(AttributeName = "Duration")]
        public int Duration { get; set; }

        [XmlAttribute(AttributeName = "Rate")]
        public int Rate { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }
}
