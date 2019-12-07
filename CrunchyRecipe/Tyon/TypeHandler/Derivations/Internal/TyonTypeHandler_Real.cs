using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Real : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_Real INSTANCE = new TyonTypeHandler_Real();

        private TyonTypeHandler_Real() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Real(value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (type.IsReal())
                return true;

            return false;
        }
    }
}
