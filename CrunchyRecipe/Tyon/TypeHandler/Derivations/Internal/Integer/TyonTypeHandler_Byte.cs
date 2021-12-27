using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Byte : TyonTypeHandler_ExplicitType<byte>
    {
        static public readonly TyonTypeHandler_Byte INSTANCE = new TyonTypeHandler_Byte();

        private TyonTypeHandler_Byte() { }

        public override TyonValue Dehydrate(Type field_type, object value, TyonDehydrater dehydrater)
        {
            return new TyonValue_Int(value, dehydrater);
        }
    }
}
