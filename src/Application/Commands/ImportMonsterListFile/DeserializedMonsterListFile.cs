using System.Xml.Serialization;

namespace Application.Commands.ImportMonsterListFile
{
    [XmlRoot(ElementName = "Monster")]
	public class DeserializedMonsterItem
	{
		[XmlAttribute(AttributeName = "Index")]
		public int Index { get; set; }

		[XmlAttribute(AttributeName = "IsTrap")]
		public int IsTrap { get; set; }

		[XmlAttribute(AttributeName = "Name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "Level")]
		public int Level { get; set; }

		[XmlAttribute(AttributeName = "HP")]
		public int HP { get; set; }

		[XmlAttribute(AttributeName = "MP")]
		public int MP { get; set; }

		[XmlAttribute(AttributeName = "DamageMin")]
		public int DamageMin { get; set; }

		[XmlAttribute(AttributeName = "DamageMax")]
		public int DamageMax { get; set; }

		[XmlAttribute(AttributeName = "Defense")]
		public int Defense { get; set; }

		[XmlAttribute(AttributeName = "MagicDefense")]
		public int MagicDefense { get; set; }

		[XmlAttribute(AttributeName = "AttackRate")]
		public int AttackRate { get; set; }

		[XmlAttribute(AttributeName = "BlockRate")]
		public int BlockRate { get; set; }

		[XmlAttribute(AttributeName = "MoveRange")]
		public int MoveRange { get; set; }

		[XmlAttribute(AttributeName = "AttackType")]
		public int AttackType { get; set; }

		[XmlAttribute(AttributeName = "AttackRange")]
		public int AttackRange { get; set; }

		[XmlAttribute(AttributeName = "ViewRange")]
		public int ViewRange { get; set; }

		[XmlAttribute(AttributeName = "MoveSpeed")]
		public int MoveSpeed { get; set; }

		[XmlAttribute(AttributeName = "AttackSpeed")]
		public int AttackSpeed { get; set; }

		[XmlAttribute(AttributeName = "RegenTime")]
		public int RegenTime { get; set; }

		[XmlAttribute(AttributeName = "Attribute")]
		public int Attribute { get; set; }

		[XmlAttribute(AttributeName = "IceRes")]
		public int IceRes { get; set; }

		[XmlAttribute(AttributeName = "PoisonRes")]
		public int PoisonRes { get; set; }

		[XmlAttribute(AttributeName = "LightRes")]
		public int LightRes { get; set; }

		[XmlAttribute(AttributeName = "FireRes")]
		public int FireRes { get; set; }

		[XmlAttribute(AttributeName = "PentagramMainAttrib")]
		public int PentagramMainAttrib { get; set; }

		[XmlAttribute(AttributeName = "PentagramAttribPattern")]
		public int PentagramAttribPattern { get; set; }

		[XmlAttribute(AttributeName = "PentagramDamageMin")]
		public int PentagramDamageMin { get; set; }

		[XmlAttribute(AttributeName = "PentagramDamageMax")]
		public int PentagramDamageMax { get; set; }

		[XmlAttribute(AttributeName = "PentagramAttackRate")]
		public int PentagramAttackRate { get; set; }

		[XmlAttribute(AttributeName = "PentagramDefenseRate")]
		public int PentagramDefenseRate { get; set; }

		[XmlAttribute(AttributeName = "PentagramDefense")]
		public int PentagramDefense { get; set; }

		[XmlAttribute(AttributeName = "EliteMonster")]
		public int EliteMonster { get; set; }

		[XmlAttribute(AttributeName = "DamageAbsorption")]
		public int DamageAbsorption { get; set; }

		[XmlAttribute(AttributeName = "CriticalDamageRes")]
		public int CriticalDamageRes { get; set; }

		[XmlAttribute(AttributeName = "ExcellentDamageRes")]
		public int ExcellentDamageRes { get; set; }

		[XmlAttribute(AttributeName = "DebuffApplyRes")]
		public int DebuffApplyRes { get; set; }

		[XmlAttribute(AttributeName = "ExpLevel")]
		public int ExpLevel { get; set; }

		[XmlAttribute(AttributeName = "ItemDropRate")]
		public int ItemDropRate { get; set; }

		[XmlAttribute(AttributeName = "MoneyDropRate")]
		public int MoneyDropRate { get; set; }

		[XmlAttribute(AttributeName = "MaxItemLevel")]
		public int MaxItemLevel { get; set; }
	}

	[XmlRoot(ElementName = "MonsterList")]
	public class DeserializedMonsterListFile
	{
		[XmlElement(ElementName = "Monster")]
		public List<DeserializedMonsterItem> Monsters { get; set; }
	}
}
