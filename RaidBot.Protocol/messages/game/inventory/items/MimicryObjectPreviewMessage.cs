using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MimicryObjectPreviewMessage : NetworkMessage
{

	public const uint Id = 6458;
	public override uint MessageId { get { return Id; } }

	public ObjectItem Result { get; set; }

	public MimicryObjectPreviewMessage() {}


	public MimicryObjectPreviewMessage InitMimicryObjectPreviewMessage(ObjectItem Result)
	{
		this.Result = Result;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Result.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Result = new ObjectItem();
		this.Result.Deserialize(reader);
	}
}
}
