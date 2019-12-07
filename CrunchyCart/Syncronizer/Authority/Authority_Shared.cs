using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public partial class Syncronizer
    {
        public class Authority_Shared : Authority
        {
            [Value]
            private List<NetworkActor> authorities;

            public Authority_Shared(IEnumerable<NetworkActor> a)
            {
                authorities = a.ToList();
            }

            public override bool IsAuthority(NetworkActor to_check)
            {
                if (to_check.IsServer() || authorities.Has(to_check))
                    return true;

                return false;
            }
        }
    }
}