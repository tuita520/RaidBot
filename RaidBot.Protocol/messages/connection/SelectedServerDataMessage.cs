using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SelectedServerDataMessage : NetworkMessage
{

	public const uint Id = 42;
	public override uint MessageId { get { return Id; } }

	public short ServerId { get; set; }
	public String Address { get; set; }
	public int[] Ports { get; set; }
	public bool CanCreateNewCharacter { get; set; }
	public byte[] Ticket { get; set; }

	public SelectedServerDataMessage() {}


	public SelectedServerDataMessage InitSelectedServerDataMessage(short ServerId, String Address, int[] Ports, bool CanCreateNewCharacter, byte[] Ticket)
	{
		this.ServerId = ServerId;
		this.Address = Address;
		this.Ports = Ports;
		this.CanCreateNewCharacter = CanCreateNewCharacter;
		this.Ticket = Ticket;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ServerId);
		writer.WriteUTF(this.Address);
		writer.WriteShort(this.Ports.Length);
		foreach (int item in this.Ports)
		{
			writer.WriteInt(item);
		}
		writer.WriteBoolean(this.CanCreateNewCharacter);
		writer.WriteVarInt(this.Ticket.Length);
		foreach (byte item in this.Ticket)
		{
			writer.WriteByte(item);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ServerId = reader.ReadVarShort();
		this.Address = reader.ReadUTF();
		int PortsLen = reader.ReadShort();
		Ports = new int[PortsLen];
		for (int i = 0; i < PortsLen; i++)
		{
			this.Ports[i] = reader.ReadInt();
		}
		this.CanCreateNewCharacter = reader.ReadBoolean();
		int TicketLen = reader.ReadVarInt();
		Ticket = new byte[TicketLen];
		for (int i = 0; i < TicketLen; i++)
		{
			this.Ticket[i] = reader.ReadByte();
		}
	}
}
}
