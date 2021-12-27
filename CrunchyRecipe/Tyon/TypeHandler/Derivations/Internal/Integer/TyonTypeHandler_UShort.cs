using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_UShort : TyonTypeHandler_ExplicitType<ushort>
    {
        static public readonly TyonTypeHandler_UShort INSTANCE = new TyonTypeHandler_UShort();

        private TyonTypeHandler_UShort() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Int(value, dehydrater);
        }
    }
}
