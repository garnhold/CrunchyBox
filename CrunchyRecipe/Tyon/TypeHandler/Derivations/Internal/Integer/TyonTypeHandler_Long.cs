using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Long : TyonTypeHandler_ExplicitType<long>
    {
        static public readonly TyonTypeHandler_Long INSTANCE = new TyonTypeHandler_Long();

        private TyonTypeHandler_Long() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Long(value, dehydrater);
        }
    }
}
