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
    using Sodium;
    
    static public class NetPeerExtensions_NetworkActor
    {
        static public long GetId(this NetPeer item)
        {
            return item.UniqueIdentifier;
        }

        static public bool IsIdLocal(this NetPeer item, long id)
        {
            if (item.GetId() == id)
                return true;

            return false;
        }

        static public bool IsIdServer(this NetPeer item, long id)
        {
            NetClient client;
            NetServer server;

            if (item.Convert<NetClient>(out client))
            {
                if (client.ServerConnection.GetId() == id)
                    return true;
            }
            else if (item.Convert<NetServer>(out server))
            {
                if (server.GetId() == id)
                    return true;
            }

            return false;
        }

        static public NetworkActor GetNetworkActor(this NetPeer item)
        {
            return item.GetNetworkActorById(item.GetId());
        }

        static public NetworkActor GetNetworkActorById(this NetPeer item, long id)
        {
            return new NetworkActor(
                id,
                item.IsIdLocal(id),
                item.IsIdServer(id)
            );
        }
    }
}