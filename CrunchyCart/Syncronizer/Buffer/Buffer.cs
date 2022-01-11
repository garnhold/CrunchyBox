using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
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