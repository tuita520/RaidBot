using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TitlesAndOrnamentsListRequestMessage : NetworkMessage
{

	public const uint Id = 6363;
	public override uint MessageId { get { return Id; } }


	public TitlesAndOrnamentsListRequestMessage() {}

	public override void Serialize(ICustomDataWriter writer)
	{
	}

	public override void Deserialize(ICustomDataReader reader)
	{
	}
}
}
