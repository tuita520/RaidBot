using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyMemberEjectedMessage : PartyMemberRemoveMessage
{

	public const uint Id = 6252;
	public override uint MessageId { get { return Id; } }

	public long KickerId { get; set; }

	public PartyMemberEjectedMessage() {}


	public PartyMemberEjectedMessage InitPartyMemberEjectedMessage(long KickerId)
	{
		this.KickerId = KickerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.KickerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.KickerId = reader.ReadVarLong();
	}
}
}
