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