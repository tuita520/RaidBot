using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicWhoIsRequestMessage : NetworkMessage
{

	public const uint Id = 181;
	public override uint MessageId { get { return Id; } }

	public bool Verbose { get; set; }
	public String Search { get; set; }

	public BasicWhoIsRequestMessage() {}


	public BasicWhoIsRequestMessage InitBasicWhoIsRequestMessage(bool Verbose, String Search)
	{
		this.Verbose = Verbose;
		this.Search = Search;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Verbose);
		writer.WriteUTF(this.Search);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Verbose = reader.ReadBoolean();
		this.Search = reader.ReadUTF();
	}
}
}
