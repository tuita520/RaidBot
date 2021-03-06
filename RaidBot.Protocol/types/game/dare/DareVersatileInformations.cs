using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DareVersatileInformations : NetworkType
{

	public const uint Id = 504;
	public override uint MessageId { get { return Id; } }

	public double DareId { get; set; }
	public int CountEntrants { get; set; }
	public int CountWinners { get; set; }

	public DareVersatileInformations() {}


	public DareVersatileInformations InitDareVersatileInformations(double DareId, int CountEntrants, int CountWinners)
	{
		this.DareId = DareId;
		this.CountEntrants = CountEntrants;
		this.CountWinners = CountWinners;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.DareId);
		writer.WriteInt(this.CountEntrants);
		writer.WriteInt(this.CountWinners);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DareId = reader.ReadDouble();
		this.CountEntrants = reader.ReadInt();
		this.CountWinners = reader.ReadInt();
	}
}
}
