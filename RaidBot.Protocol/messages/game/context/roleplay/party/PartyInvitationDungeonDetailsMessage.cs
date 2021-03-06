using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyInvitationDungeonDetailsMessage : PartyInvitationDetailsMessage
{

	public const uint Id = 6262;
	public override uint MessageId { get { return Id; } }

	public short DungeonId { get; set; }
	public bool[] PlayersDungeonReady { get; set; }

	public PartyInvitationDungeonDetailsMessage() {}


	public PartyInvitationDungeonDetailsMessage InitPartyInvitationDungeonDetailsMessage(short DungeonId, bool[] PlayersDungeonReady)
	{
		this.DungeonId = DungeonId;
		this.PlayersDungeonReady = PlayersDungeonReady;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.DungeonId);
		writer.WriteShort(this.PlayersDungeonReady.Length);
		foreach (bool item in this.PlayersDungeonReady)
		{
			writer.WriteBoolean(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.DungeonId = reader.ReadVarShort();
		int PlayersDungeonReadyLen = reader.ReadShort();
		PlayersDungeonReady = new bool[PlayersDungeonReadyLen];
		for (int i = 0; i < PlayersDungeonReadyLen; i++)
		{
			this.PlayersDungeonReady[i] = reader.ReadBoolean();
		}
	}
}
}
