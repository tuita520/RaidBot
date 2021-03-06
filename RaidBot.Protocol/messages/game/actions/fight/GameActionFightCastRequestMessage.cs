using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightCastRequestMessage : NetworkMessage
{

	public const uint Id = 1005;
	public override uint MessageId { get { return Id; } }

	public short SpellId { get; set; }
	public short CellId { get; set; }

	public GameActionFightCastRequestMessage() {}


	public GameActionFightCastRequestMessage InitGameActionFightCastRequestMessage(short SpellId, short CellId)
	{
		this.SpellId = SpellId;
		this.CellId = CellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SpellId);
		writer.WriteShort(this.CellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SpellId = reader.ReadVarShort();
		this.CellId = reader.ReadShort();
	}
}
}
