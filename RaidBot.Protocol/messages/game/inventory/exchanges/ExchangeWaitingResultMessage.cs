using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeWaitingResultMessage : NetworkMessage
{

	public const uint Id = 5786;
	public override uint MessageId { get { return Id; } }

	public bool Bwait { get; set; }

	public ExchangeWaitingResultMessage() {}


	public ExchangeWaitingResultMessage InitExchangeWaitingResultMessage(bool Bwait)
	{
		this.Bwait = Bwait;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Bwait);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Bwait = reader.ReadBoolean();
	}
}
}
