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
        public class Message
        {
            private NetworkEnvelope envelope;

            private Buffer buffer;

            public Message(NetworkEnvelope e, Syncronizer s)
            {
                envelope = e;

                buffer = new Buffer(envelope.GetMessage(), s.GetNetworkActor(), s);
            }

            public void Send()
            {
                envelope.Send();
            }

            public void Send(NetworkRecipient recipient)
            {
                recipient.Send(envelope);
            }

            public Buffer GetBuffer()
            {
                return buffer;
            }
        }
    }
}