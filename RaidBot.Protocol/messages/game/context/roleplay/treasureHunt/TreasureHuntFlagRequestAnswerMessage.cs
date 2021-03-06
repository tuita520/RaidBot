using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TreasureHuntFlagRequestAnswerMessage : NetworkMessage
{

	public const uint Id = 6507;
	public override uint MessageId { get { return Id; } }

	public byte QuestType { get; set; }
	public byte Result { get; set; }
	public byte Index { get; set; }

	public TreasureHuntFlagRequestAnswerMessage() {}


	public TreasureHuntFlagRequestAnswerMessage InitTreasureHuntFlagRequestAnswerMessage(byte QuestType, byte Result, byte Index)
	{
		this.QuestType = QuestType;
		this.Result = Result;
		this.Index = Index;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.QuestType);
		writer.WriteByte(this.Result);
		writer.WriteByte(this.Index);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.QuestType = reader.ReadByte();
		this.Result = reader.ReadByte();
		this.Index = reader.ReadByte();
	}
}
}
