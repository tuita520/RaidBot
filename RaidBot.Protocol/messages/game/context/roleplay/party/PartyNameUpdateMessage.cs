using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyNameUpdateMessage : AbstractPartyMessage
{

	public const uint Id = 6502;
	public override uint MessageId { get { return Id; } }

	public String PartyName { get; set; }

	public PartyNameUpdateMessage() {}


	public PartyNameUpdateMessage InitPartyNameUpdateMessage(String PartyName)
	{
		this.PartyName = PartyName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.PartyName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PartyName = reader.ReadUTF();
	}
}
}
