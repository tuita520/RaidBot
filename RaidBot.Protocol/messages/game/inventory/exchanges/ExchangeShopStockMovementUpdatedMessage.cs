using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeShopStockMovementUpdatedMessage : NetworkMessage
{

	public const uint Id = 5909;
	public override uint MessageId { get { return Id; } }

	public ObjectItemToSell ObjectInfo { get; set; }

	public ExchangeShopStockMovementUpdatedMessage() {}


	public ExchangeShopStockMovementUpdatedMessage InitExchangeShopStockMovementUpdatedMessage(ObjectItemToSell ObjectInfo)
	{
		this.ObjectInfo = ObjectInfo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.ObjectInfo.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectInfo = new ObjectItemToSell();
		this.ObjectInfo.Deserialize(reader);
	}
}
}
