﻿using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonBridge_CalculateExternal_Type_Type : TyonBridge_CalculateExternal_Type<Type, string>
    {
        static public readonly TyonBridge_CalculateExternal_Type_Type INSTANCE = new TyonBridge_CalculateExternal_Type_Type();

        protected override string CalculateAddressInternal(Type value, TyonDehydrater dehydrater)
        {
            return TyonType.CreateTyonType(value).Render();
        }

        protected override Type ResolveAddressInternal(string address, TyonHydrater hydrater)
        {
            return TyonType.DOMify(address).GetSystemType(hydrater);
        }

        private TyonBridge_CalculateExternal_Type_Type() { }
    }
}
