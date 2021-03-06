using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInfosUpgradeMessage : NetworkMessage
{

	public const uint Id = 5636;
	public override uint MessageId { get { return Id; } }

	public byte MaxTaxCollectorsCount { get; set; }
	public byte TaxCollectorsCount { get; set; }
	public short TaxCollectorLifePoints { get; set; }
	public short TaxCollectorDamagesBonuses { get; set; }
	public short TaxCollectorPods { get; set; }
	public short TaxCollectorProspecting { get; set; }
	public short TaxCollectorWisdom { get; set; }
	public short BoostPoints { get; set; }
	public short[] SpellId { get; set; }
	public short[] SpellLevel { get; set; }

	public GuildInfosUpgradeMessage() {}


	public GuildInfosUpgradeMessage InitGuildInfosUpgradeMessage(byte MaxTaxCollectorsCount, byte TaxCollectorsCount, short TaxCollectorLifePoints, short TaxCollectorDamagesBonuses, short TaxCollectorPods, short TaxCollectorProspecting, short TaxCollectorWisdom, short BoostPoints, short[] SpellId, short[] SpellLevel)
	{
		this.MaxTaxCollectorsCount = MaxTaxCollectorsCount;
		this.TaxCollectorsCount = TaxCollectorsCount;
		this.TaxCollectorLifePoints = TaxCollectorLifePoints;
		this.TaxCollectorDamagesBonuses = TaxCollectorDamagesBonuses;
		this.TaxCollectorPods = TaxCollectorPods;
		this.TaxCollectorProspecting = TaxCollectorProspecting;
		this.TaxCollectorWisdom = TaxCollectorWisdom;
		this.BoostPoints = BoostPoints;
		this.SpellId = SpellId;
		this.SpellLevel = SpellLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.MaxTaxCollectorsCount);
		writer.WriteByte(this.TaxCollectorsCount);
		writer.WriteVarShort(this.TaxCollectorLifePoints);
		writer.WriteVarShort(this.TaxCollectorDamagesBonuses);
		writer.WriteVarShort(this.TaxCollectorPods);
		writer.WriteVarShort(this.TaxCollectorProspecting);
		writer.WriteVarShort(this.TaxCollectorWisdom);
		writer.WriteVarShort(this.BoostPoints);
		writer.WriteShort(this.SpellId.Length);
		foreach (short item in this.SpellId)
		{
			writer.WriteVarShort(item);
		}
		writer.WriteShort(this.SpellLevel.Length);
		foreach (short item in this.SpellLevel)
		{
			writer.WriteShort(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MaxTaxCollectorsCount = reader.ReadByte();
		this.TaxCollectorsCount = reader.ReadByte();
		this.TaxCollectorLifePoints = reader.ReadVarShort();
		this.TaxCollectorDamagesBonuses = reader.ReadVarShort();
		this.TaxCollectorPods = reader.ReadVarShort();
		this.TaxCollectorProspecting = reader.ReadVarShort();
		this.TaxCollectorWisdom = reader.ReadVarShort();
		this.BoostPoints = reader.ReadVarShort();
		int SpellIdLen = reader.ReadShort();
		SpellId = new short[SpellIdLen];
		for (int i = 0; i < SpellIdLen; i++)
		{
			this.SpellId[i] = reader.ReadVarShort();
		}
		int SpellLevelLen = reader.ReadShort();
		SpellLevel = new short[SpellLevelLen];
		for (int i = 0; i < SpellLevelLen; i++)
		{
			this.SpellLevel[i] = reader.ReadShort();
		}
	}
}
}
