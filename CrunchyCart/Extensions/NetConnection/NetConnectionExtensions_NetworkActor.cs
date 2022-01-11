using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class NetConnectionExtensions_NetworkActor
    {
        static public long GetId(this NetConnection item)
        {
            return item.RemoteUniqueIdentifier;
        }

        static public NetworkActor GetNetworkActor(this NetConnection item)
        {
            return item.Peer.GetNetworkActorById(item.GetId());
        }
    }
}