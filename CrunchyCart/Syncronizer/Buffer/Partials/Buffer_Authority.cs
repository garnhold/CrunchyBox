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