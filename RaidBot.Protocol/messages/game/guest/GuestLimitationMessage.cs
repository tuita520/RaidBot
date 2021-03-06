using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuestLimitationMessage : NetworkMessage
{

	public const uint Id = 6506;
	public override uint MessageId { get { return Id; } }

	public byte Reason { get; set; }

	public GuestLimitationMessage() {}


	public GuestLimitationMessage InitGuestLimitationMessage(byte Reason)
	{
		this.Reason = Reason;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Reason);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Reason = reader.ReadByte();
	}
}
}
