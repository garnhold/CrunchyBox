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
        public class EntityTypeAttribute : DataTypeAttribute
        {
            public EntityTypeAttribute(Interval dui) : base(dui) { }
            public EntityTypeAttribute() : this(Interval.Default) { }
        }
    }
}