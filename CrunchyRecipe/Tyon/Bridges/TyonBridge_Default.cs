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

        public override TyonValue CreateTyonValue(VariableInstance variable, TyonDehydrater dehydrater)
        {
            Type type = variable.GetContents().GetType();

            if (type.IsString())
                return new TyonValue_String(variable, dehydrater);

            if (type.IsNumeric())
                return new TyonValue_Number(variable, dehydrater);

            if (type.IsEnumType())
                return new TyonValue_String(variable, dehydrater);

            if (type.IsTypicalIEnumerable())
                return new TyonValue_Array(variable, dehydrater);

            if (dehydrater.GetDesignatedVariables(type).IsNotEmpty())
                return new TyonValue_Object(variable, dehydrater);

            if (variable.GetVariableType().CanHaveChildTypes() == false)
                return new TyonValue_String(variable, dehydrater);

            return new TyonValue_Surrogate(variable, dehydrater);
        }

        public override object ResolveTyonAddress(TyonAddress address, Variable variable, TyonHydrater hydrater)
        {
            throw new InvalidOperationException(GetType() + " cannot resolve addresses.");
        }

        public override bool IsCompatible(Variable variable)
        {
            return true;
        }
    }
}
