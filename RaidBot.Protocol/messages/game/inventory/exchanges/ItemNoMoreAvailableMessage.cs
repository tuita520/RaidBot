using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ItemNoMoreAvailableMessage : NetworkMessage
{

	public const uint Id = 5769;
	public override uint MessageId { get { return Id; } }


	public ItemNoMoreAvailableMessage() {}

	public override void Serialize(ICustomDataWriter writer)
	{
	}

	public override void Deserialize(ICustomDataReader reader)
	{
	}
}
}
