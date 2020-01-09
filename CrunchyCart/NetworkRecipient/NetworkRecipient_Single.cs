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
    
    public class NetworkRecipient_Single : NetworkRecipient
    {
        private NetConnection recipient;

        public NetworkRecipient_Single(NetConnection r)
        {
            recipient = r;
        }

        public override void Send(NetworkEnvelope envelope)
        {
            envelope.Send(recipient);
        }
    }
}