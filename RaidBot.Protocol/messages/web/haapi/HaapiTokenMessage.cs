using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HaapiTokenMessage : NetworkMessage
{

	public const uint Id = 6767;
	public override uint MessageId { get { return Id; } }

	public String Token { get; set; }

	public HaapiTokenMessage() {}


	public HaapiTokenMessage InitHaapiTokenMessage(String Token)
	{
		this.Token = Token;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.Token);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Token = reader.ReadUTF();
	}
}
}
