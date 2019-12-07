using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_String : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_String INSTANCE = new TyonTypeHandler_String();

        private TyonTypeHandler_String() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_String(value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (type.IsString())
                return true;

            return false;
        }
    }
}
