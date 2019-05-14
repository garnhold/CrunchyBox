using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public partial class Buffer
        {
            private NetBuffer buffer;
            private NetworkActor sender;

            private Syncronizer syncronizer;

            private BufferDefermentException deferment_exception;

            public Buffer(NetBuffer b, NetworkActor a, Syncronizer s)
            {
                buffer = b;

                sender = a;
                syncronizer = s;
            }

            public NetworkActor GetSender()
            {
                return sender;
            }

            public Syncronizer GetSyncronizer()
            {
                return syncronizer;
            }
        }
    }
}