using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public class TyonContext
	{
        private TyonSettings settings;

        private int next_registered_external_address;
        private BidirectionalDictionary<object, object> registered_external_address_to_objects;

        public TyonContext(TyonSettings s)
        {
            settings = s;

            next_registered_external_address = 1;
            registered_external_address_to_objects = new BidirectionalDictionary<object, object>();
        }

        public TyonDehydrater CreateDehydrater()
        {
            return new TyonDehydrater(this);
        }
        public TyonHydrater CreateHydrater(TyonHydrationMode mode)
        {
            return new TyonHydrater(mode, this);
        }

        public string Serialize(object obj)
        {
            return CreateDehydrater().Dehydrate(obj).Render();
        }
        public string SerializeValue(object value, Type type)
        {
            return CreateDehydrater().DehydrateValue(value, type).Render();
        }

        public object Deserialize(string text, TyonHydrationMode mode)
        {
            return CreateHydrater(mode).Hydrate(text);
        }
        public T Deserialize<T>(string text, TyonHydrationMode mode)
        {
            return Deserialize(text, mode).Convert<T>();
        }

        public object DeserializeValue(string text, Type type, TyonHydrationMode mode)
        {
            return CreateHydrater(mode).HydrateValue(text, type);
        }
        public T DeserializeValue<T>(string text, TyonHydrationMode mode)
        {
            return DeserializeValue(text, typeof(T), mode).Convert<T>();
        }

        public void DeserializeInto(object obj, string text, TyonHydrationMode mode)
        {
            CreateHydrater(mode).HydrateInto(obj, text);
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
            return settings.GetBridge(variable);
        }

        public TyonSettings GetSettings()
        {
            return settings;
        }

        public IEnumerable<object> GetRegisteredExternalObjects()
        {
            return registered_external_address_to_objects.Convert(p => p.Value);
        }
	}
	
}
