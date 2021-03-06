using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightStealKamaMessage : AbstractGameActionMessage
{

	public const uint Id = 5535;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }
	public long Amount { get; set; }

	public GameActionFightStealKamaMessage() {}


	public GameActionFightStealKamaMessage InitGameActionFightStealKamaMessage(double TargetId, long Amount)
	{
		this.TargetId = TargetId;
		this.Amount = Amount;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.TargetId);
		writer.WriteVarLong(this.Amount);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TargetId = reader.ReadDouble();
		this.Amount = reader.ReadVarLong();
	}
}
}
