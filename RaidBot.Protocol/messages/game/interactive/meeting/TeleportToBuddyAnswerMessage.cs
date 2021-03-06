using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TeleportToBuddyAnswerMessage : NetworkMessage
{

	public const uint Id = 6293;
	public override uint MessageId { get { return Id; } }

	public short DungeonId { get; set; }
	public long BuddyId { get; set; }
	public bool Accept { get; set; }

	public TeleportToBuddyAnswerMessage() {}


	public TeleportToBuddyAnswerMessage InitTeleportToBuddyAnswerMessage(short DungeonId, long BuddyId, bool Accept)
	{
		this.DungeonId = DungeonId;
		this.BuddyId = BuddyId;
		this.Accept = Accept;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.DungeonId);
		writer.WriteVarLong(this.BuddyId);
		writer.WriteBoolean(this.Accept);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DungeonId = reader.ReadVarShort();
		this.BuddyId = reader.ReadVarLong();
		this.Accept = reader.ReadBoolean();
	}
}
}
