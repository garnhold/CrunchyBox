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
    
    public abstract class NetworkPeer : NetworkPeerBase
    {
        public event NetworkMessageProcessor OnData;
        public event NetworkMessageProcessor OnConnect;
        public event NetworkMessageProcessor OnDisconnect;

        protected override bool ProcessData(NetIncomingMessage message)
        {
            return OnData.InvokeAll(message);
        }

        protected override bool ProcessStatusConnected(NetIncomingMessage message)
        {
            return OnConnect.InvokeAll(message);
        }

        protected override bool ProcessStatusDisconnected(NetIncomingMessage message)
        {
            return OnDisconnect.InvokeAll(message);
        }
    }
}