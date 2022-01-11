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