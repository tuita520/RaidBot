using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DecraftedItemStackInfo : NetworkType
{

	public const uint Id = 481;
	public override uint MessageId { get { return Id; } }

	public int ObjectUID { get; set; }
	public float BonusMin { get; set; }
	public float BonusMax { get; set; }
	public short[] RunesId { get; set; }
	public int[] RunesQty { get; set; }

	public DecraftedItemStackInfo() {}


	public DecraftedItemStackInfo InitDecraftedItemStackInfo(int ObjectUID, float BonusMin, float BonusMax, short[] RunesId, int[] RunesQty)
	{
		this.ObjectUID = ObjectUID;
		this.BonusMin = BonusMin;
		this.BonusMax = BonusMax;
		this.RunesId = RunesId;
		this.RunesQty = RunesQty;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ObjectUID);
		writer.WriteFloat(this.BonusMin);
		writer.WriteFloat(this.BonusMax);
		writer.WriteShort(this.RunesId.Length);
		foreach (short item in this.RunesId)
		{
			writer.WriteVarShort(item);
		}
		writer.WriteShort(this.RunesQty.Length);
		foreach (int item in this.RunesQty)
		{
			writer.WriteVarInt(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectUID = reader.ReadVarInt();
		this.BonusMin = reader.ReadFloat();
		this.BonusMax = reader.ReadFloat();
		int RunesIdLen = reader.ReadShort();
		RunesId = new short[RunesIdLen];
		for (int i = 0; i < RunesIdLen; i++)
		{
			this.RunesId[i] = reader.ReadVarShort();
		}
		int RunesQtyLen = reader.ReadShort();
		RunesQty = new int[RunesQtyLen];
		for (int i = 0; i < RunesQtyLen; i++)
		{
			this.RunesQty[i] = reader.ReadVarInt();
		}
	}
}
}
