﻿using System.Collections;
using System.Collections.Generic;
using LiteNetLibManager;
using LiteNetLib.Utils;

namespace Insthync.MMOG
{
    public class RequestSpawnMapMessage : BaseAckMessage
    {
        public int spawnId;
        public string sceneName;

        public override void DeserializeData(NetDataReader reader)
        {
            spawnId = reader.GetInt();
            sceneName = reader.GetString();
        }

        public override void SerializeData(NetDataWriter writer)
        {
            writer.Put(spawnId);
            writer.Put(sceneName);
        }
    }
}