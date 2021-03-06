using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightMarkCellsMessage : AbstractGameActionMessage
{

	public const uint Id = 5540;
	public override uint MessageId { get { return Id; } }

	public GameActionMark Mark { get; set; }

	public GameActionFightMarkCellsMessage() {}


	public GameActionFightMarkCellsMessage InitGameActionFightMarkCellsMessage(GameActionMark Mark)
	{
		this.Mark = Mark;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.Mark.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Mark = new GameActionMark();
		this.Mark.Deserialize(reader);
	}
}
}
