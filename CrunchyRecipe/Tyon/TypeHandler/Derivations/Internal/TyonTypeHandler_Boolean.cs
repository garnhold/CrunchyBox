using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Boolean : TyonTypeHandler_ExplicitType<bool>
    {
        static public readonly TyonTypeHandler_Boolean INSTANCE = new TyonTypeHandler_Boolean();

        private TyonTypeHandler_Boolean() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Boolean(value, dehydrater);
        }
    }
}
