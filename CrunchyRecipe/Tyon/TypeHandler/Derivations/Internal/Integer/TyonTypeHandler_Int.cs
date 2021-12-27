using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Int : TyonTypeHandler_ExplicitType<int>
    {
        static public readonly TyonTypeHandler_Int INSTANCE = new TyonTypeHandler_Int();

        private TyonTypeHandler_Int() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Int(value, dehydrater);
        }
    }
}
