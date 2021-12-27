using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Short : TyonTypeHandler_ExplicitType<short>
    {
        static public readonly TyonTypeHandler_Short INSTANCE = new TyonTypeHandler_Short();

        private TyonTypeHandler_Short() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Int(value, dehydrater);
        }
    }
}
