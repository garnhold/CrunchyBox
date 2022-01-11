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
        public class EntityTypeAttribute : DataTypeAttribute
        {
            public EntityTypeAttribute(Interval dui) : base(dui) { }
            public EntityTypeAttribute() : this(Interval.Default) { }
        }
    }
}