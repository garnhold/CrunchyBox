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
        public class Authority_Any : Authority
        {
            static public readonly Authority_Any INSTANCE = new Authority_Any();

            private Authority_Any() { }

            public override bool IsAuthority(NetworkActor to_check)
            {
                return true;
            }
        }
    }
}