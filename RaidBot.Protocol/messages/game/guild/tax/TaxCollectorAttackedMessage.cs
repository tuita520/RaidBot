using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorAttackedMessage : NetworkMessage
{

	public const uint Id = 5918;
	public override uint MessageId { get { return Id; } }

	public short FirstNameId { get; set; }
	public short LastNameId { get; set; }
	public short WorldX { get; set; }
	public short WorldY { get; set; }
	public double MapId { get; set; }
	public short SubAreaId { get; set; }
	public BasicGuildInformations Guild { get; set; }

	public TaxCollectorAttackedMessage() {}


	public TaxCollectorAttackedMessage InitTaxCollectorAttackedMessage(short FirstNameId, short LastNameId, short WorldX, short WorldY, double MapId, short SubAreaId, BasicGuildInformations Guild)
	{
		this.FirstNameId = FirstNameId;
		this.LastNameId = LastNameId;
		this.WorldX = WorldX;
		this.WorldY = WorldY;
		this.MapId = MapId;
		this.SubAreaId = SubAreaId;
		this.Guild = Guild;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FirstNameId);
		writer.WriteVarShort(this.LastNameId);
		writer.WriteShort(this.WorldX);
		writer.WriteShort(this.WorldY);
		writer.WriteDouble(this.MapId);
		writer.WriteVarShort(this.SubAreaId);
		this.Guild.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FirstNameId = reader.ReadVarShort();
		this.LastNameId = reader.ReadVarShort();
		this.WorldX = reader.ReadShort();
		this.WorldY = reader.ReadShort();
		this.MapId = reader.ReadDouble();
		this.SubAreaId = reader.ReadVarShort();
		this.Guild = new BasicGuildInformations();
		this.Guild.Deserialize(reader);
	}
}
}
