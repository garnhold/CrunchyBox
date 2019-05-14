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
    public delegate bool NetworkMessageProcessor(NetIncomingMessage message);

    static public class NetworkMessageProcessorExtensions
    {
        static public bool InvokeAll(this NetworkMessageProcessor item, NetIncomingMessage message)
        {
            if (item != null)
            {
                return item.GetInvocationList().ProcessAND(delegate(Delegate d) {
                    message.Position = 0;

                    return (bool)d.DynamicInvoke(message);
                });
            }

            return true;
        }
    }
}