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
        [AttributeUsage(AttributeTargets.Class)]
        public class DataTypeAttribute : Attribute
        {
            private Interval default_update_interval;

            public DataTypeAttribute(Interval dui)
            {
                default_update_interval = dui;
            }

            public DataTypeAttribute() : this(Interval.Default) { }

            public Interval GetDefaultUpdateInterval()
            {
                return default_update_interval;
            }
        }
    }
}