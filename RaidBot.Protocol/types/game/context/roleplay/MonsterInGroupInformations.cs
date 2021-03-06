using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class MonsterInGroupInformations : MonsterInGroupLightInformations
{

	public const uint Id = 144;
	public override uint MessageId { get { return Id; } }

	public EntityLook Look { get; set; }

	public MonsterInGroupInformations() {}


	public MonsterInGroupInformations InitMonsterInGroupInformations(EntityLook Look)
	{
		this.Look = Look;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.Look.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Look = new EntityLook();
		this.Look.Deserialize(reader);
	}
}
}
