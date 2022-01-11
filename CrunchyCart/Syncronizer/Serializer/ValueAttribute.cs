using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class Syncronizer
    {
        [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
        public class ValueAttribute : Attribute
        {
            private Interval update_interval;

            public ValueAttribute(Interval ui)
            {
                update_interval = ui;
            }

            public ValueAttribute() : this(Interval.Default) { }

            public Interval GetUpdateInterval()
            {
                return update_interval;
            }
        }
    }
}