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
    public class NetworkRecipient_Single : NetworkRecipient
    {
        private NetConnection recipient;

        public NetworkRecipient_Single(NetConnection r)
        {
            recipient = r;
        }

        public override void Send(NetDeliveryMethod delivery_method, int delivery_channel, NetOutgoingMessage message, NetPeer peer)
        {
            peer.SendMessage(message, recipient, delivery_method, delivery_channel);
        }
    }
}