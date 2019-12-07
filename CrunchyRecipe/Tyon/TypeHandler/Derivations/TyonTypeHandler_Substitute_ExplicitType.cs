using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonTypeHandler_Substitute_ExplicitType<INPUT_TYPE, OUTPUT_TYPE> : TyonTypeHandler_Substitute_ExplicitType<INPUT_TYPE>
    {
        static public readonly TyonTypeHandler_Substitute_ExplicitType<INPUT_TYPE, OUTPUT_TYPE> INSTANCE = new TyonTypeHandler_Substitute_ExplicitType<INPUT_TYPE, OUTPUT_TYPE>();

        protected override object SubstituteInternal(INPUT_TYPE value)
        {
            return value.ConvertEX<OUTPUT_TYPE>();
        }

        protected TyonTypeHandler_Substitute_ExplicitType() { }
    }

    public abstract class TyonTypeHandler_Substitute_ExplicitType<INPUT_TYPE> : TyonTypeHandler_Substitute
    {
        protected abstract object SubstituteInternal(INPUT_TYPE value);

        protected override object Substitute(object value)
        {
            return SubstituteInternal(value.ConvertEX<INPUT_TYPE>());
        }

        public override bool IsCompatible(Type type)
        {
            if (type.CanBeTreatedAs<INPUT_TYPE>())
                return true;

            return false;
        }
    }
}
