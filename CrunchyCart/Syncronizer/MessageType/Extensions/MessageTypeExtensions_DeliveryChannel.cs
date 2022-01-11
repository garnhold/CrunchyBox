using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class MessageTypeExtensions_DeliveryChannel
    {
        static public int GetDeliveryChannel(this Syncronizer.MessageType item)
        {
            switch (item)
            {
                case Syncronizer.MessageType.RequestConstant: return 0;
                case Syncronizer.MessageType.UpdateConstant: return 0;
                case Syncronizer.MessageType.FullUpdateConstant: return 0;

                case Syncronizer.MessageType.InvokeEntityMethod: return 1;
                case Syncronizer.MessageType.ChangeEntityAuthority: return 1;
                case Syncronizer.MessageType.UpdateEntity: return 1;
                case Syncronizer.MessageType.DestroyEntity: return 1;

                case Syncronizer.MessageType.InvokeSystemMethod: return 1;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}