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
    public class NetworkRecipient_All : NetworkRecipient
    {
        static public readonly NetworkRecipient_All INSTANCE = new NetworkRecipient_All();

        private NetworkRecipient_All() { }

        public override void Send(NetDeliveryMethod delivery_method, int delivery_channel, NetOutgoingMessage message, NetPeer peer)
        {
            if (peer.Connections.IsNotEmpty())
                peer.SendMessage(message, peer.Connections, delivery_method, delivery_channel);
        }
    }
}