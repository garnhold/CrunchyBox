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
    
    public class NetworkEnvelope
    {
        private NetOutgoingMessage message;

        private NetDeliveryMethod delivery_method;
        private int delivery_channel;

        private NetPeer net_peer;

        public NetworkEnvelope(NetDeliveryMethod ndm, int dc, NetPeer n)
        {
            delivery_method = ndm;
            delivery_channel = dc;

            message = n.CreateMessage();

            net_peer = n;
        }

        public void Send(NetConnection recipient)
        {
            net_peer.SendMessage(message, recipient, delivery_method, delivery_channel);
        }

        public void Send(IList<NetConnection> recipients)
        {
            if (recipients.IsNotEmpty())
                net_peer.SendMessage(message, recipients, delivery_method, delivery_channel);
        }

        public void Send()
        {
            Send(net_peer.Connections);
        }

        public NetOutgoingMessage GetMessage()
        {
            return message;
        }
    }
}