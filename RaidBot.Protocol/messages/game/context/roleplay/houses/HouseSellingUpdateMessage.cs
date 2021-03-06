using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseSellingUpdateMessage : NetworkMessage
{

	public const uint Id = 6727;
	public override uint MessageId { get { return Id; } }

	public int HouseId { get; set; }
	public int InstanceId { get; set; }
	public bool SecondHand { get; set; }
	public long RealPrice { get; set; }
	public String BuyerName { get; set; }

	public HouseSellingUpdateMessage() {}


	public HouseSellingUpdateMessage InitHouseSellingUpdateMessage(int HouseId, int InstanceId, bool SecondHand, long RealPrice, String BuyerName)
	{
		this.HouseId = HouseId;
		this.InstanceId = InstanceId;
		this.SecondHand = SecondHand;
		this.RealPrice = RealPrice;
		this.BuyerName = BuyerName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.HouseId);
		writer.WriteInt(this.InstanceId);
		writer.WriteBoolean(this.SecondHand);
		writer.WriteVarLong(this.RealPrice);
		writer.WriteUTF(this.BuyerName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.HouseId = reader.ReadVarInt();
		this.InstanceId = reader.ReadInt();
		this.SecondHand = reader.ReadBoolean();
		this.RealPrice = reader.ReadVarLong();
		this.BuyerName = reader.ReadUTF();
	}
}
}
