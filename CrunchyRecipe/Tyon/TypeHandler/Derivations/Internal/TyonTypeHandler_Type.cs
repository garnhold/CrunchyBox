using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Type : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_Type INSTANCE = new TyonTypeHandler_Type();

        private TyonTypeHandler_Type() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Type(value.ConvertEX<Type>(), dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            if (type.IsTypeType())
                return true;

            return false;
        }
    }
}
