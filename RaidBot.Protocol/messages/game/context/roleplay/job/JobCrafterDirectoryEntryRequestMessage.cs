using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class JobCrafterDirectoryEntryRequestMessage : NetworkMessage
{

	public const uint Id = 6043;
	public override uint MessageId { get { return Id; } }

	public long PlayerId { get; set; }

	public JobCrafterDirectoryEntryRequestMessage() {}


	public JobCrafterDirectoryEntryRequestMessage InitJobCrafterDirectoryEntryRequestMessage(long PlayerId)
	{
		this.PlayerId = PlayerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.PlayerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PlayerId = reader.ReadVarLong();
	}
}
}
