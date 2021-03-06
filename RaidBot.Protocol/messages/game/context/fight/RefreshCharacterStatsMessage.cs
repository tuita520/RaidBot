using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class RefreshCharacterStatsMessage : NetworkMessage
{

	public const uint Id = 6699;
	public override uint MessageId { get { return Id; } }

	public double FighterId { get; set; }
	public GameFightMinimalStats Stats { get; set; }

	public RefreshCharacterStatsMessage() {}


	public RefreshCharacterStatsMessage InitRefreshCharacterStatsMessage(double FighterId, GameFightMinimalStats Stats)
	{
		this.FighterId = FighterId;
		this.Stats = Stats;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.FighterId);
		this.Stats.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FighterId = reader.ReadDouble();
		this.Stats = new GameFightMinimalStats();
		this.Stats.Deserialize(reader);
	}
}
}
