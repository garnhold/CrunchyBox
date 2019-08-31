using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonTypeHandler_MethodInfo : TyonTypeHandler_Surrogate_ExplicitType<MethodInfo, Tuple<Type, string, Type[]>>
    {
        static public readonly TyonTypeHandler_MethodInfo INSTANCE = new TyonTypeHandler_MethodInfo();

        protected override Tuple<Type, string, Type[]> CreateSurrogateInternal(MethodInfo value, TyonDehydrater dehydrater)
        {
            return Tuple.New(
                value.DeclaringType,
                value.Name,
                value.GetTechnicalParameterTypes().ToArray()
            );
        }

        protected override MethodInfo ResolveSurrogateInternal(Tuple<Type, string, Type[]> surrogate, TyonHydrater hydrater)
        {
            return surrogate.item1.GetFilteredMethods(
                Filterer_MethodInfo.IsNamed(surrogate.item2),
                Filterer_MethodInfo.CanTechnicalParametersHold(surrogate.item3)
            ).GetFirst();
        }

        private TyonTypeHandler_MethodInfo() { }
    }
}
