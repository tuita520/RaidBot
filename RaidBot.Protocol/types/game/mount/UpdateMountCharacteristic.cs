using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class UpdateMountCharacteristic : NetworkType
{

	public const uint Id = 536;
	public override uint MessageId { get { return Id; } }

	public byte Type { get; set; }

	public UpdateMountCharacteristic() {}


	public UpdateMountCharacteristic InitUpdateMountCharacteristic(byte Type)
	{
		this.Type = Type;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Type);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Type = reader.ReadByte();
	}
}
}
