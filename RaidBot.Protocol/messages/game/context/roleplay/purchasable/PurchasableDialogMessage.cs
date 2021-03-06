using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PurchasableDialogMessage : NetworkMessage
{

	public const uint Id = 5739;
	public override uint MessageId { get { return Id; } }

	public bool BuyOrSell { get; set; }
	public bool SecondHand { get; set; }
	public double PurchasableId { get; set; }
	public int PurchasableInstanceId { get; set; }
	public long Price { get; set; }

	public PurchasableDialogMessage() {}


	public PurchasableDialogMessage InitPurchasableDialogMessage(bool BuyOrSell, bool SecondHand, double PurchasableId, int PurchasableInstanceId, long Price)
	{
		this.BuyOrSell = BuyOrSell;
		this.SecondHand = SecondHand;
		this.PurchasableId = PurchasableId;
		this.PurchasableInstanceId = PurchasableInstanceId;
		this.Price = Price;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		byte box = 0;
		box = BooleanByteWrapper.SetFlag(box, 0, BuyOrSell);
		box = BooleanByteWrapper.SetFlag(box, 1, SecondHand);
		writer.WriteByte(box);
		writer.WriteDouble(this.PurchasableId);
		writer.WriteInt(this.PurchasableInstanceId);
		writer.WriteVarLong(this.Price);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		byte box = reader.ReadByte();
		this.BuyOrSell = BooleanByteWrapper.GetFlag(box, 0);
		this.SecondHand = BooleanByteWrapper.GetFlag(box, 1);
		this.PurchasableId = reader.ReadDouble();
		this.PurchasableInstanceId = reader.ReadInt();
		this.Price = reader.ReadVarLong();
	}
}
}
