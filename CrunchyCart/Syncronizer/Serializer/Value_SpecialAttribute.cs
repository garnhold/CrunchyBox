using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
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