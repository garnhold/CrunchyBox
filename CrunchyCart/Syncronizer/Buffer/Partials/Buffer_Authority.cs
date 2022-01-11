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
        public partial class Buffer
        {
            public Authority ReadAuthority()
            {
                return TypeSerializer.ReadPolymorphicObject<Authority>(this);
            }

            public void WriteAuthority(Authority value)
            {
                TypeSerializer.WritePolymorphicObject(value, this);
            }
        }
    }
}