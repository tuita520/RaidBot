using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntStepFollowDirectionToHint : TreasureHuntStep
{

	public const uint Id = 472;
	public override uint MessageId { get { return Id; } }

	public byte Direction { get; set; }
	public short NpcId { get; set; }

	public TreasureHuntStepFollowDirectionToHint() {}


	public TreasureHuntStepFollowDirectionToHint InitTreasureHuntStepFollowDirectionToHint(byte Direction, short NpcId)
	{
		this.Direction = Direction;
		this.NpcId = NpcId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Direction);
		writer.WriteVarShort(this.NpcId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Direction = reader.ReadByte();
		this.NpcId = reader.ReadVarShort();
	}
}
}
