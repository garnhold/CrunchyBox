using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public partial class Buffer
        {
            public NetworkActor ReadNetworkActor()
            {
                return syncronizer.GetNetworkActorById(ReadInt64());
            }

            public void WriteNetworkActor(NetworkActor value)
            {
                WriteInt64(value.GetId());
            }
        }
    }
}