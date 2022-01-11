using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
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