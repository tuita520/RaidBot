using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayArenaUpdatePlayerInfosMessage : NetworkMessage
{

	public const uint Id = 6301;
	public override uint MessageId { get { return Id; } }

	public ArenaRankInfos Solo { get; set; }

	public GameRolePlayArenaUpdatePlayerInfosMessage() {}


	public GameRolePlayArenaUpdatePlayerInfosMessage InitGameRolePlayArenaUpdatePlayerInfosMessage(ArenaRankInfos Solo)
	{
		this.Solo = Solo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Solo.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Solo = new ArenaRankInfos();
		this.Solo.Deserialize(reader);
	}
}
}
