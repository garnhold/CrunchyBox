using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
        public abstract class Value_SpecialAttribute : ValueAttribute
        {
            public abstract TypeSerializerProp CreateTypeSerializerProp(TypeBuilder type_builder, PropInfoEX prop);

            public Value_SpecialAttribute(Interval ui) : base(ui) { }
            public Value_SpecialAttribute() : this(Interval.Default) { }
        }
    }
}