using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ItemForPreset : NetworkType
{

	public const uint Id = 540;
	public override uint MessageId { get { return Id; } }

	public short Position { get; set; }
	public short ObjGid { get; set; }
	public int ObjUid { get; set; }

	public ItemForPreset() {}


	public ItemForPreset InitItemForPreset(short Position, short ObjGid, int ObjUid)
	{
		this.Position = Position;
		this.ObjGid = ObjGid;
		this.ObjUid = ObjUid;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Position);
		writer.WriteVarShort(this.ObjGid);
		writer.WriteVarInt(this.ObjUid);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Position = reader.ReadShort();
		this.ObjGid = reader.ReadVarShort();
		this.ObjUid = reader.ReadVarInt();
	}
}
}
