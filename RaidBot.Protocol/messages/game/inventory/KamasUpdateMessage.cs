using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class KamasUpdateMessage : NetworkMessage
{

	public const uint Id = 5537;
	public override uint MessageId { get { return Id; } }

	public long KamasTotal { get; set; }

	public KamasUpdateMessage() {}


	public KamasUpdateMessage InitKamasUpdateMessage(long KamasTotal)
	{
		this.KamasTotal = KamasTotal;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.KamasTotal);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.KamasTotal = reader.ReadVarLong();
	}
}
}
