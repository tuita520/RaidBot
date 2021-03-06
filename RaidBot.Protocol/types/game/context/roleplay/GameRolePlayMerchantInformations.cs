using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
{

	public const uint Id = 129;
	public override uint MessageId { get { return Id; } }

	public byte SellType { get; set; }
	public HumanOption[] Options { get; set; }

	public GameRolePlayMerchantInformations() {}


	public GameRolePlayMerchantInformations InitGameRolePlayMerchantInformations(byte SellType, HumanOption[] Options)
	{
		this.SellType = SellType;
		this.Options = Options;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.SellType);
		writer.WriteShort(this.Options.Length);
		foreach (HumanOption item in this.Options)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.SellType = reader.ReadByte();
		int OptionsLen = reader.ReadShort();
		Options = new HumanOption[OptionsLen];
		for (int i = 0; i < OptionsLen; i++)
		{
			this.Options[i] = ProtocolTypeManager.GetInstance<HumanOption>(reader.ReadShort());
			this.Options[i].Deserialize(reader);
		}
	}
}
}
