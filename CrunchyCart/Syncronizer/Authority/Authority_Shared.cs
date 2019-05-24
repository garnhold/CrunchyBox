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