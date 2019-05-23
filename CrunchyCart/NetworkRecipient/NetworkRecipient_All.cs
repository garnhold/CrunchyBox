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

        public override void Send(NetworkEnvelope envelope)
        {
            envelope.Send();
        }
    }
}