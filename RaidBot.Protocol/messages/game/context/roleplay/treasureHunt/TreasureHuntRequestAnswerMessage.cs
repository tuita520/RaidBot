using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntRequestAnswerMessage : NetworkMessage
{

	public const uint Id = 6489;
	public override uint MessageId { get { return Id; } }

	public byte QuestType { get; set; }
	public byte Result { get; set; }

	public TreasureHuntRequestAnswerMessage() {}


	public TreasureHuntRequestAnswerMessage InitTreasureHuntRequestAnswerMessage(byte QuestType, byte Result)
	{
		this.QuestType = QuestType;
		this.Result = Result;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.QuestType);
		writer.WriteByte(this.Result);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.QuestType = reader.ReadByte();
		this.Result = reader.ReadByte();
	}
}
}
