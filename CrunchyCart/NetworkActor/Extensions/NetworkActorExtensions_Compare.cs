using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class NetworkActorExtensions_Compare
    {
        static public bool IsClient(this NetworkActor item)
        {
            if (item.IsServer() == false)
                return true;

            return false;
        }

        static public bool IsRemote(this NetworkActor item)
        {
            if (item.IsLocal() == false)
                return true;

            return false;
        }
    }
}