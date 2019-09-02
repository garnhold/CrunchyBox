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

        private long next_external_address;
        private BidirectionalDictionary<object, object> external_address_to_objects;

        public TyonContext(TyonSettings s)
        {
            settings = s;

            next_external_address = 1;
            external_address_to_objects = new BidirectionalDictionary<object, object>();
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
        public string SerializeValue(Type type, object value)
        {
            return CreateDehydrater().DehydrateValue(type, value).Render();
        }

        public object Deserialize(string text, TyonHydrationMode mode)
        {
            return CreateHydrater(mode).Hydrate(text);
        }
        public T Deserialize<T>(string text, TyonHydrationMode mode)
        {
            return Deserialize(text, mode).Convert<T>();
        }

        public object DeserializeValue(Type type, string text, TyonHydrationMode mode)
        {
            return CreateHydrater(mode).HydrateValue(type, text);
        }
        public T DeserializeValue<T>(string text, TyonHydrationMode mode)
        {
            return DeserializeValue(typeof(T), text, mode).Convert<T>();
        }

        public void DeserializeInto(object obj, string text, TyonHydrationMode mode)
        {
            CreateHydrater(mode).HydrateInto(obj, text);
        }

        public object RegisterExternalObject(object obj)
        {
            object address;

            if (external_address_to_objects.TryGetValueByRight(obj, out address) == false)
            {
                address = next_external_address++;
                external_address_to_objects.Add(address, obj);
            }

            return address;
        }
        public void RegisterExternalObjects(IEnumerable<object> objs)
        {
            objs.Process(o => RegisterExternalObject(o));
        }

        public bool TryResolveExternalObject(object obj, out object address)
        {
            return external_address_to_objects.TryGetValueByRight(obj, out address);
        }
        public object ResolveExternalObject(object obj)
        {
            object address;

            TryResolveExternalObject(obj, out address);
            return address;
        }

        public bool TryResolveExternalAddress(object address, out object obj)
        {
            return external_address_to_objects.TryGetValueByLeft(address, out obj);
        }
        public object ResolveExternalAddress(object address)
        {
            object obj;

            TryResolveExternalAddress(address, out obj);
            return obj;
        }

        public TyonSettings GetSettings()
        {
            return settings;
        }

        public IEnumerable<object> GetRegisteredExternalObjects()
        {
            return external_address_to_objects.Convert(p => p.Value);
        }
	}
	
}
