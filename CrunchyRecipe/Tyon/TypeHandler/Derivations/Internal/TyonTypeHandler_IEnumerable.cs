using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_IEnumerable : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_IEnumerable INSTANCE = new TyonTypeHandler_IEnumerable();

        private TyonTypeHandler_IEnumerable() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Array(field_type.GetIEnumerableType(), value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (type.IsTypicalIEnumerable())
                return true;

            return false;
        }
    }
}
