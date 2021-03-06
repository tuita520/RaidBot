using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AchievementFinishedMessage : NetworkMessage
{

	public const uint Id = 6208;
	public override uint MessageId { get { return Id; } }

	public AchievementAchievedRewardable Achievement { get; set; }

	public AchievementFinishedMessage() {}


	public AchievementFinishedMessage InitAchievementFinishedMessage(AchievementAchievedRewardable Achievement)
	{
		this.Achievement = Achievement;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Achievement.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Achievement = new AchievementAchievedRewardable();
		this.Achievement.Deserialize(reader);
	}
}
}
