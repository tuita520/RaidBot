using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeLeaveMessage : LeaveDialogMessage
{

	public const uint Id = 5628;
	public override uint MessageId { get { return Id; } }

	public bool Success { get; set; }

	public ExchangeLeaveMessage() {}


	public ExchangeLeaveMessage InitExchangeLeaveMessage(bool Success)
	{
		this.Success = Success;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteBoolean(this.Success);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Success = reader.ReadBoolean();
	}
}
}
