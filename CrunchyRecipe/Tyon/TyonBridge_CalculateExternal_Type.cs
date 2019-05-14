using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonBridge_CalculateExternal_Type<VALUE_TYPE, ADDRESS_TYPE> : TyonBridge_CalculateExternal_Type
    {
        protected abstract ADDRESS_TYPE CalculateAddressInternal(VALUE_TYPE value);
        protected abstract VALUE_TYPE ResolveAddressInternal(ADDRESS_TYPE address);

        protected override object CalculateAddress(object value, Variable variable, TyonContext_Dehydration context)
        {
            return CalculateAddressInternal(value.ConvertEX<VALUE_TYPE>());
        }

        protected override object ResolveAddress(object address, Variable variable, TyonContext_Hydration context)
        {
            return ResolveAddressInternal(address.ConvertEX<ADDRESS_TYPE>());
        }

        public TyonBridge_CalculateExternal_Type() : base(typeof(VALUE_TYPE)) { }
    }

    public abstract class TyonBridge_CalculateExternal_Type : TyonBridge_CalculateExternal
    {
        private Type type;

        public TyonBridge_CalculateExternal_Type(Type t)
        {
            type = t;
        }

        public override bool IsCompatible(Variable variable)
        {
            if (variable.GetVariableType().CanBeTreatedAs(type))
                return true;

            return false;
        }
    }
}
