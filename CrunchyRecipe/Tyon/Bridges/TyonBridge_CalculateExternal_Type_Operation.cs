using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonBridge_CalculateExternal_Type_Operation<VALUE_TYPE, ADDRESS_TYPE> : TyonBridge_CalculateExternal_Type<VALUE_TYPE, ADDRESS_TYPE>
    {
        private Operation<ADDRESS_TYPE, VALUE_TYPE> calculate_address;
        private Operation<VALUE_TYPE, ADDRESS_TYPE> resolve_address;

        protected override ADDRESS_TYPE CalculateAddressInternal(VALUE_TYPE value)
        {
            return calculate_address(value);
        }

        protected override VALUE_TYPE ResolveAddressInternal(ADDRESS_TYPE address)
        {
            return resolve_address(address);
        }

        public TyonBridge_CalculateExternal_Type_Operation(Operation<ADDRESS_TYPE, VALUE_TYPE> ca, Operation<VALUE_TYPE, ADDRESS_TYPE> ra)
        {
            calculate_address = ca;
            resolve_address = ra;
        }
    }
}
