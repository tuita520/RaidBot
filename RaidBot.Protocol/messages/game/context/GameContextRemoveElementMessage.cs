using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameContextRemoveElementMessage : NetworkMessage
{

	public const uint Id = 251;
	public override uint MessageId { get { return Id; } }

	public double Id_ { get; set; }

	public GameContextRemoveElementMessage() {}


	public GameContextRemoveElementMessage InitGameContextRemoveElementMessage(double Id_)
	{
		this.Id_ = Id_;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.Id_);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Id_ = reader.ReadDouble();
	}
}
}
