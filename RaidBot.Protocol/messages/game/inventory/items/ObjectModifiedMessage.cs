using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ObjectModifiedMessage : NetworkMessage
{

	public const uint Id = 3029;
	public override uint MessageId { get { return Id; } }

	public ObjectItem Object { get; set; }

	public ObjectModifiedMessage() {}


	public ObjectModifiedMessage InitObjectModifiedMessage(ObjectItem Object)
	{
		this.Object = Object;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Object.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Object = new ObjectItem();
		this.Object.Deserialize(reader);
	}
}
}
