using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class LifePointsRegenEndMessage : UpdateLifePointsMessage
{

	public const uint Id = 5686;
	public override uint MessageId { get { return Id; } }

	public int LifePointsGained { get; set; }

	public LifePointsRegenEndMessage() {}


	public LifePointsRegenEndMessage InitLifePointsRegenEndMessage(int LifePointsGained)
	{
		this.LifePointsGained = LifePointsGained;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.LifePointsGained);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.LifePointsGained = reader.ReadVarInt();
	}
}
}
