using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public class NetworkClient : NetworkPeer
    {
        private NetClient client;

        protected override bool ProcessConnectionApproval(NetIncomingMessage message)
        {
            message.SenderConnection.Deny();
            return true;
        }

        protected override NetPeer GetNetPeer()
        {
            return client;
        }

        public NetworkClient(NetworkConfiguration c, IPAddress a, string p)
        {
            client = new NetClient(c.CreateNetClientConfiguration());

            client.Start();
            client.Connect(new IPEndPoint(a, c.GetPort()), client.CreateMessage(p));
        }
    }
}