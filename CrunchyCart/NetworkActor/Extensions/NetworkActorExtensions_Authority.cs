using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class NetworkActorExtensions_Authority
    {
        static public bool IsAuthority(this NetworkActor item, Syncronizer.Authority authority)
        {
            if (authority.IsAuthority(item))
                return true;

            return false;
        }
    }
}