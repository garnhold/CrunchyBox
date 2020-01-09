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
    
    public delegate bool NetworkMessageProcessor(NetIncomingMessage message);

    static public class NetworkMessageProcessorExtensions
    {
        static public bool InvokeAll(this NetworkMessageProcessor item, NetIncomingMessage message)
        {
            if (item != null)
            {
                return item.GetInvocationList().ProcessAND(delegate(Delegate d) {
                    message.Position = 0;

                    return ((NetworkMessageProcessor)d)(message);
                });
            }

            return true;
        }
    }
}