using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StartupActionAddMessage : NetworkMessage
{

	public const uint Id = 6538;
	public override uint MessageId { get { return Id; } }

	public StartupActionAddObject NewAction { get; set; }

	public StartupActionAddMessage() {}


	public StartupActionAddMessage InitStartupActionAddMessage(StartupActionAddObject NewAction)
	{
		this.NewAction = NewAction;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.NewAction.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.NewAction = new StartupActionAddObject();
		this.NewAction.Deserialize(reader);
	}
}
}
