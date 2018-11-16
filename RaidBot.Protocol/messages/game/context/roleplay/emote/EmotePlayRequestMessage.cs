


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class EmotePlayRequestMessage : NetworkMessage
{

public const uint Id = 5685;
public override uint MessageId
{
    get { return Id; }
}

public byte emoteId;
        

public EmotePlayRequestMessage()
{
}

public EmotePlayRequestMessage(byte emoteId)
        {
            this.emoteId = emoteId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteByte(emoteId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

emoteId = reader.ReadByte();
            if (emoteId < 0 || emoteId > 255)
                throw new Exception("Forbidden value on emoteId = " + emoteId + ", it doesn't respect the following condition : emoteId < 0 || emoteId > 255");
            

}


}


}