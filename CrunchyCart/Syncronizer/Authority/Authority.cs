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
        [DataType]
        public abstract class Authority
        {
            public abstract bool IsAuthority(NetworkActor to_check);
        }
    }
}