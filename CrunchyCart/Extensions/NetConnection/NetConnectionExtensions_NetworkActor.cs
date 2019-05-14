using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
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