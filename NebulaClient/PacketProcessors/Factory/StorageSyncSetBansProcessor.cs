﻿using NebulaModel.Networking;
using NebulaModel.Packets.Factory;
using NebulaModel.Packets.Processors;
using NebulaWorld.Factory;
using NebulaModel.Attributes;

namespace NebulaClient.PacketProcessors.Factory
{
    [RegisterPacketProcessor]
    class StorageSyncSetBansProcessor : IPacketProcessor<StorageSyncSetBansPacket>
    {
        public void ProcessPacket(StorageSyncSetBansPacket packet, NebulaConnection conn)
        {
            StorageComponent storage = null;
            StorageComponent[] pool = GameMain.localPlanet?.factory?.factoryStorage?.storagePool;
            if (pool != null && packet.StorageIndex != -1 && packet.StorageIndex < pool.Length)
            {
                storage = pool[packet.StorageIndex];
            }

            if (storage != null)
            {
                StorageManager.EventFromClient = true;
                storage.SetBans(packet.Bans);
                StorageManager.EventFromClient = false;
            }
        }
    }
}