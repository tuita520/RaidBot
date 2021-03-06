using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FriendDeleteResultMessage : NetworkMessage
{

	public const uint Id = 5601;
	public override uint MessageId { get { return Id; } }

	public bool Success { get; set; }
	public String Name { get; set; }

	public FriendDeleteResultMessage() {}


	public FriendDeleteResultMessage InitFriendDeleteResultMessage(bool Success, String Name)
	{
		this.Success = Success;
		this.Name = Name;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Success);
		writer.WriteUTF(this.Name);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Success = reader.ReadBoolean();
		this.Name = reader.ReadUTF();
	}
}
}
