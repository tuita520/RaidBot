using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ArenaFighterLeaveMessage : NetworkMessage
{

	public const uint Id = 6700;
	public override uint MessageId { get { return Id; } }

	public CharacterBasicMinimalInformations Leaver { get; set; }

	public ArenaFighterLeaveMessage() {}


	public ArenaFighterLeaveMessage InitArenaFighterLeaveMessage(CharacterBasicMinimalInformations Leaver)
	{
		this.Leaver = Leaver;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Leaver.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Leaver = new CharacterBasicMinimalInformations();
		this.Leaver.Deserialize(reader);
	}
}
}
