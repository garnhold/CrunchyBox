using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
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