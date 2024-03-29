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
        public class Authority_Server : Authority
        {
            static public readonly Authority_Server INSTANCE = new Authority_Server();

            private Authority_Server() { }

            public override bool IsAuthority(NetworkActor to_check)
            {
                if (to_check.IsServer())
                    return true;

                return false;
            }
        }
    }
}