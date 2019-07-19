using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonBridge_CalculateExternal_Type_MethodInfo : TyonBridge_CalculateExternal_Type<MethodInfo, Tuple<Type, string, Type[]>>
    {
        static public readonly TyonBridge_CalculateExternal_Type_MethodInfo INSTANCE = new TyonBridge_CalculateExternal_Type_MethodInfo();

        protected override Tuple<Type, string, Type[]> CalculateAddressInternal(MethodInfo value)
        {
            return Tuple.New(
                value.DeclaringType,
                value.Name,
                value.GetTechnicalParameterTypes().ToArray()
            );
        }

        protected override MethodInfo ResolveAddressInternal(Tuple<Type, string, Type[]> address)
        {
            return address.item1.GetFilteredInstanceMethods(
                Filterer_MethodInfo.IsNamed(address.item2),
                Filterer_MethodInfo.CanTechnicalParametersHold(address.item3)
            ).GetFirst();
        }

        private TyonBridge_CalculateExternal_Type_MethodInfo() { }
    }
}
