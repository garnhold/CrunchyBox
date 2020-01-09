using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public class NetworkServer : NetworkPeer
    {
        private NetServer server;
        private StretchedHash password_hash;

        protected override bool ProcessConnectionApproval(NetIncomingMessage message)
        {
            if (password_hash.Verify(message.ReadString()))
                message.SenderConnection.Approve();
            else
                message.SenderConnection.Deny("Password Incorrect.");

            return true;
        }

        protected override NetPeer GetNetPeer()
        {
            return server;
        }

        public NetworkServer(NetworkConfiguration c, string p)
        {
            server = new NetServer(c.CreateNetServerConfiguration());
            password_hash = new StretchedHash(p);

            server.Start();
        }
    }
}