using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonBridge_Default : TyonBridge
    {
        static public readonly TyonBridge_Default INSTANCE = new TyonBridge_Default();

        private TyonBridge_Default() { }

        public override TyonValue CreateTyonValue(object value, Variable variable, TyonContext_Dehydration context)
        {
            Type type = value.GetType();

            if (type.IsString())
                return new TyonValue_String(value, context);

            if (type.IsNumeric())
                return new TyonValue_Number(value, context);

            if (type.IsTypicalIEnumerable())
                return new TyonValue_Array(value, variable, context);

            if (context.GetDesignatedVariables(type).IsNotEmpty())
                return new TyonValue_Object(value, context);

            if (variable.GetVariableType().CanHaveChildTypes() == false)
                return new TyonValue_String(value, context);

            return new TyonValue_Surrogate(value, context);
        }

        public override object ResolveTyonAddress(TyonAddress address, Variable variable, TyonContext_Hydration context)
        {
            throw new InvalidOperationException(GetType() + " cannot resolve addresses.");
        }

        public override bool IsCompatible(Variable variable)
        {
            return true;
        }
    }
}
