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
        private long next_internal_address;
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

        public TyonValue DehydrateValue(Type type, object value)
        {
            TyonValue tyon_value = CreateTyonValue(type, value);

            Finish();
            return tyon_value;
        }

        public TyonValue CreateTyonValue(Type field_type, object value)
        {
            if (value != null)
            {
                Type value_type = value.GetType();

                TyonAddress address;
                if (context.TryResolveExternalObject(value, out address))
                    return new TyonValue_ExternalAddress(address, this);

                TyonAddressable addressable;
                if (object_to_tyon_addressable.TryGetValue(value, out addressable))
                    return new TyonValue_InternalAddress(addressable.RequestAddress(this), this);

                return context.GetSettings().GetTypeHandler(value_type).Dehydrate(field_type, value, this);
            }

            return new TyonValue_Null();
        }

        public void RegisterInternalObject(object obj, TyonAddressable addressable)
        {
            if (obj.GetType().IsTypicalReferenceType())
                object_to_tyon_addressable.Add(obj, addressable);
        }

        public TyonAddress RegisterExternalObject(object obj)
        {
            return context.RegisterExternalObject(obj);
        }

        public TyonAddress GetNewInternalAddress()
        {
            return new TyonAddress_Integer(next_internal_address++);
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
