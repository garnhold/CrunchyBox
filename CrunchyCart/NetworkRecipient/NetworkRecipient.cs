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
    public abstract class NetworkRecipient
    {
        public abstract void Send(NetworkEnvelope envelope);
    }
}