using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartedBidBuyerMessage : NetworkMessage
{

	public const uint Id = 5904;
	public override uint MessageId { get { return Id; } }

	public SellerBuyerDescriptor BuyerDescriptor { get; set; }

	public ExchangeStartedBidBuyerMessage() {}


	public ExchangeStartedBidBuyerMessage InitExchangeStartedBidBuyerMessage(SellerBuyerDescriptor BuyerDescriptor)
	{
		this.BuyerDescriptor = BuyerDescriptor;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.BuyerDescriptor.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.BuyerDescriptor = new SellerBuyerDescriptor();
		this.BuyerDescriptor.Deserialize(reader);
	}
}
}
