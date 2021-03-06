using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightTurnStartMessage : NetworkMessage
{

	public const uint Id = 714;
	public override uint MessageId { get { return Id; } }

	public double Id_ { get; set; }
	public int WaitTime { get; set; }

	public GameFightTurnStartMessage() {}


	public GameFightTurnStartMessage InitGameFightTurnStartMessage(double Id_, int WaitTime)
	{
		this.Id_ = Id_;
		this.WaitTime = WaitTime;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.Id_);
		writer.WriteVarInt(this.WaitTime);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadDouble();
		this.WaitTime = reader.ReadVarInt();
	}
}
}
