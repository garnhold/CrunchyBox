using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Fallback : TyonTypeHandler
    {
        static public readonly TyonTypeHandler_Fallback INSTANCE = new TyonTypeHandler_Fallback();

        private TyonTypeHandler_Fallback() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            if (value.IsToStringOverridden())
            {
                if (field_type.CanHaveChildTypes())
                    return new TyonValue_Surrogate(value, dehydrater);

                return new TyonValue_String(value, dehydrater);
            }

            return new TyonValue_Object(value, dehydrater);
        }

        public override bool IsCompatible(Type type)
        {
            return true;
        }
    }
}
