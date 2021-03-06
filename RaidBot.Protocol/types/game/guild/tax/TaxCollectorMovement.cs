using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorMovement : NetworkType
{

	public const uint Id = 493;
	public override uint MessageId { get { return Id; } }

	public byte MovementType { get; set; }
	public TaxCollectorBasicInformations BasicInfos { get; set; }
	public long PlayerId { get; set; }
	public String PlayerName { get; set; }

	public TaxCollectorMovement() {}


	public TaxCollectorMovement InitTaxCollectorMovement(byte MovementType, TaxCollectorBasicInformations BasicInfos, long PlayerId, String PlayerName)
	{
		this.MovementType = MovementType;
		this.BasicInfos = BasicInfos;
		this.PlayerId = PlayerId;
		this.PlayerName = PlayerName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.MovementType);
		this.BasicInfos.Serialize(writer);
		writer.WriteVarLong(this.PlayerId);
		writer.WriteUTF(this.PlayerName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MovementType = reader.ReadByte();
		this.BasicInfos = new TaxCollectorBasicInformations();
		this.BasicInfos.Deserialize(reader);
		this.PlayerId = reader.ReadVarLong();
		this.PlayerName = reader.ReadUTF();
	}
}
}
