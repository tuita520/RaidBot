using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeRequestOnTaxCollectorMessage : NetworkMessage
{

	public const uint Id = 5779;
	public override uint MessageId { get { return Id; } }


	public ExchangeRequestOnTaxCollectorMessage() {}

	public override void Serialize(ICustomDataWriter writer)
	{
	}

	public override void Deserialize(ICustomDataReader reader)
	{
	}
}
}
