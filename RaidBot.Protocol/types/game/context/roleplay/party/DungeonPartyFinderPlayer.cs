using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DungeonPartyFinderPlayer : NetworkType
{

	public const uint Id = 373;
	public override uint MessageId { get { return Id; } }

	public long PlayerId { get; set; }
	public String PlayerName { get; set; }
	public byte Breed { get; set; }
	public bool Sex { get; set; }
	public short Level { get; set; }

	public DungeonPartyFinderPlayer() {}


	public DungeonPartyFinderPlayer InitDungeonPartyFinderPlayer(long PlayerId, String PlayerName, byte Breed, bool Sex, short Level)
	{
		this.PlayerId = PlayerId;
		this.PlayerName = PlayerName;
		this.Breed = Breed;
		this.Sex = Sex;
		this.Level = Level;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.PlayerId);
		writer.WriteUTF(this.PlayerName);
		writer.WriteByte(this.Breed);
		writer.WriteBoolean(this.Sex);
		writer.WriteVarShort(this.Level);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PlayerId = reader.ReadVarLong();
		this.PlayerName = reader.ReadUTF();
		this.Breed = reader.ReadByte();
		this.Sex = reader.ReadBoolean();
		this.Level = reader.ReadVarShort();
	}
}
}
