using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CompassUpdatePvpSeekMessage : CompassUpdateMessage
{

	public const uint Id = 6013;
	public override uint MessageId { get { return Id; } }

	public long MemberId { get; set; }
	public String MemberName { get; set; }

	public CompassUpdatePvpSeekMessage() {}


	public CompassUpdatePvpSeekMessage InitCompassUpdatePvpSeekMessage(long MemberId, String MemberName)
	{
		this.MemberId = MemberId;
		this.MemberName = MemberName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarLong(this.MemberId);
		writer.WriteUTF(this.MemberName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.MemberId = reader.ReadVarLong();
		this.MemberName = reader.ReadUTF();
	}
}
}
