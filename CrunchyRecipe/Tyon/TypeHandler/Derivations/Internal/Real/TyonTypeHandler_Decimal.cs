using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Decimal : TyonTypeHandler_ExplicitType<decimal>
    {
        static public readonly TyonTypeHandler_Decimal INSTANCE = new TyonTypeHandler_Decimal();

        private TyonTypeHandler_Decimal() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Decimal(value, dehydrater);
        }
    }
}
