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