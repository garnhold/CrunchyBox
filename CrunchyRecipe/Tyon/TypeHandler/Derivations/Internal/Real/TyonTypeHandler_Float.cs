using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Float : TyonTypeHandler_ExplicitType<float>
    {
        static public readonly TyonTypeHandler_Float INSTANCE = new TyonTypeHandler_Float();

        private TyonTypeHandler_Float() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Float(value, dehydrater);
        }
    }
}
