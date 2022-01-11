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
    
    public class NetworkRecipient_Multiple : NetworkRecipient
    {
        private IList<NetConnection> recipients;

        public NetworkRecipient_Multiple(IList<NetConnection> rs)
        {
            recipients = rs;
        }

        public override void Send(NetworkEnvelope envelope)
        {
            envelope.Send(recipients);
        }
    }
}