using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public class TyonDehydrater
	{
        private int next_internal_address;
        private Dictionary<object, TyonAddressable> object_to_tyon_addressable;

        private TyonContext context;

        private void Finish()
        {
            Clear();
        }

        public TyonDehydrater(TyonContext c)
        {
            next_internal_address = 1;
            object_to_tyon_addressable = new Dictionary<object, TyonAddressable>();

            context = c;
        }

        public void Clear()
        {
            next_internal_address = 1;
            object_to_tyon_addressable.Clear();
        }

        public TyonObject Dehydrate(object obj)
        {
            TyonObject tyon_object = new TyonObject(obj, this);

            Finish();
            return tyon_object;
        }

        public TyonValue DehydrateValue(object value, Type type)
        {
            VariableInstance variable = new Variable_Static_Value("value", type, value)
                .CreateInstance();

            TyonValue tyon_value = CreateTyonValue(variable);

            Finish();
            return tyon_value;
        }

        public TyonValue CreateTyonValue(VariableInstance variable)
        {
            object value = variable.GetContents();

            if (value != null)
            {
                object address;
                if (context.TryResolveRegisteredExternalObject(value, out address))
                    return new TyonValue_ExternalAddress(address, this);

                TyonAddressable addressable;
                if (object_to_tyon_addressable.TryGetValue(value, out addressable))
                    return new TyonValue_InternalAddress(addressable.RequestAddress(this), this);

                return context.GetBridge(variable.GetVariable()).CreateTyonValue(variable, this);
            }

            return new TyonValue_Null();
        }

        public TyonAddress CreateTyonAddress(object value)
        {
            Type type = value.GetType();

            if (type.IsString())
            {
                string cast = (string)value;

                if (cast.IsId())
                    return new TyonAddress_Identifier(cast, this);

                return new TyonAddress_String(cast, this);
            }

            if (type.IsInteger())
            {
                int cast = (int)value;

                return new TyonAddress_Int(cast, this);
            }

            return new TyonAddress_Object(value, this);
        }

        public void RegisterInternalObject(object obj, TyonAddressable addressable)
        {
            if (obj.GetType().IsTypicalReferenceType())
                object_to_tyon_addressable.Add(obj, addressable);
        }

        public object RegisterExternalObject(object obj)
        {
            return context.RegisterExternalObject(obj);
        }

        public TyonAddress GetNewInternalAddress()
        {
            return new TyonAddress_Int(next_internal_address++, this);
        }

        public IEnumerable<Variable> GetDesignatedVariables(Type type)
        {
            return context.GetSettings().GetDesignatedVariables(type);
        }

        public TyonContext GetContext()
        {
            return context;
        }
	}
	
}
