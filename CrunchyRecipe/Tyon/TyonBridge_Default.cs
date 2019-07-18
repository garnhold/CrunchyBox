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

        public override TyonValue CreateTyonValue(VariableInstance variable, TyonContext_Dehydration context)
        {
            Type type = variable.GetContents().GetType();

            if (type.IsString())
                return new TyonValue_String(variable, context);

            if (type.IsNumeric())
                return new TyonValue_Number(variable, context);

            if (type.IsEnumType())
                return new TyonValue_String(variable, context);

            if (type.IsTypeType())
                return new TyonValue_Type(variable, context);

            if (type.IsTypicalIEnumerable())
                return new TyonValue_Array(variable, context);

            if (context.GetDesignatedVariables(type).IsNotEmpty())
                return new TyonValue_Object(variable, context);

            if (variable.GetVariableType().CanHaveChildTypes() == false)
                return new TyonValue_String(variable, context);

            return new TyonValue_Surrogate(variable, context);
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
