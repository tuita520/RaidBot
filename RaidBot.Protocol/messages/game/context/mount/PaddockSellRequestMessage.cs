using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PaddockSellRequestMessage : NetworkMessage
{

	public const uint Id = 5953;
	public override uint MessageId { get { return Id; } }

	public long Price { get; set; }
	public bool ForSale { get; set; }

	public PaddockSellRequestMessage() {}


	public PaddockSellRequestMessage InitPaddockSellRequestMessage(long Price, bool ForSale)
	{
		this.Price = Price;
		this.ForSale = ForSale;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.Price);
		writer.WriteBoolean(this.ForSale);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Price = reader.ReadVarLong();
		this.ForSale = reader.ReadBoolean();
	}
}
}
