using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildFightPlayersEnemiesListMessage : NetworkMessage
{

	public const uint Id = 5928;
	public override uint MessageId { get { return Id; } }

	public double FightId { get; set; }
	public CharacterMinimalPlusLookInformations[] PlayerInfo { get; set; }

	public GuildFightPlayersEnemiesListMessage() {}


	public GuildFightPlayersEnemiesListMessage InitGuildFightPlayersEnemiesListMessage(double FightId, CharacterMinimalPlusLookInformations[] PlayerInfo)
	{
		this.FightId = FightId;
		this.PlayerInfo = PlayerInfo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.FightId);
		writer.WriteShort(this.PlayerInfo.Length);
		foreach (CharacterMinimalPlusLookInformations item in this.PlayerInfo)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadDouble();
		int PlayerInfoLen = reader.ReadShort();
		PlayerInfo = new CharacterMinimalPlusLookInformations[PlayerInfoLen];
		for (int i = 0; i < PlayerInfoLen; i++)
		{
			this.PlayerInfo[i] = new CharacterMinimalPlusLookInformations();
			this.PlayerInfo[i].Deserialize(reader);
		}
	}
}
}
