using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class EditHavenBagFinishedMessage : NetworkMessage
{

	public const uint Id = 6628;
	public override uint MessageId { get { return Id; } }


	public EditHavenBagFinishedMessage() {}

	public override void Serialize(ICustomDataWriter writer)
	{
	}

	public override void Deserialize(ICustomDataReader reader)
	{
	}
}
}
