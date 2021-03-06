using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PortalDialogCreationMessage : NpcDialogCreationMessage
{

	public const uint Id = 6737;
	public override uint MessageId { get { return Id; } }

	public int Type { get; set; }

	public PortalDialogCreationMessage() {}


	public PortalDialogCreationMessage InitPortalDialogCreationMessage(int Type)
	{
		this.Type = Type;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.Type);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Type = reader.ReadInt();
	}
}
}
