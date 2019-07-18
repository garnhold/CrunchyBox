using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public abstract class TyonContext
	{
        private TyonSerializer serializer;

        private int next_registered_external_address;
        private BidirectionalDictionary<object, object> registered_external_address_to_objects;

        public TyonContext(TyonSerializer s)
        {
            serializer = s;

            next_registered_external_address = 1;
            registered_external_address_to_objects = new BidirectionalDictionary<object, object>();
        }

        public object RegisterExternalObject(object obj)
        {
            object address;

            if (registered_external_address_to_objects.TryGetValueByRight(obj, out address) == false)
            {
                address = next_registered_external_address++;
                registered_external_address_to_objects.Add(address, obj);
            }

            return address;
        }
        public void RegisterExternalObjects(IEnumerable<object> objs)
        {
            objs.Process(o => RegisterExternalObject(o));
        }

        public bool TryResolveRegisteredExternalObject(object obj, out object address)
        {
            return registered_external_address_to_objects.TryGetValueByRight(obj, out address);
        }
        public object ResolveRegisteredExternalObject(object obj)
        {
            object address;

            TryResolveRegisteredExternalObject(obj, out address);
            return address;
        }

        public bool TryResolveRegisteredExternalAddress(object address, out object obj)
        {
            return registered_external_address_to_objects.TryGetValueByLeft(address, out obj);
        }
        public object ResolveRegisteredExternalAddress(object address)
        {
            object obj;

            TryResolveRegisteredExternalAddress(address, out obj);
            return obj;
        }

        public TyonBridge GetBridge(Variable variable)
        {
            return serializer.GetBridge(variable);
        }

        public TyonSerializer GetSerializer()
        {
            return serializer;
        }

        public IEnumerable<object> GetRegisteredExternalObjects()
        {
            return registered_external_address_to_objects.Convert(p => p.Value);
        }
	}
	
}
