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
        public class Authority_Normal : Authority
        {
            [Value]
            private NetworkActor authority;

            public Authority_Normal(NetworkActor a)
            {
                authority = a;
            }

            public override bool IsAuthority(NetworkActor to_check)
            {
                if (to_check.IsServer() || authority.GetId() == to_check.GetId())
                    return true;

                return false;
            }
        }
    }
}