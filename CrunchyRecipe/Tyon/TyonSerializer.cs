using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonSerializer
    {
        private List<TyonBridge> bridges;
        private List<TyonDesignatedVariableProvider> variable_providers;

        private OperationCache<TyonBridge, Variable> bridges_cache;
        private OperationCache<Dictionary<string, Variable>, Type> designated_variables_cache;

        public TyonSerializer(IEnumerable<TyonBridge> b, IEnumerable<TyonDesignatedVariableProvider> v)
        {
            bridges = b.ToList();
            bridges.Process(z => z.SetSerializer(this));

            variable_providers = v.ToList();
            variable_providers.Process(z => z.SetSerializer(this));

            bridges_cache = new OperationCache<TyonBridge, Variable>(delegate(Variable variable) {
                return bridges.FindFirst(z => z.IsCompatible(variable)) ?? TyonBridge_Default.INSTANCE;
            });

            designated_variables_cache = new OperationCache<Dictionary<string, Variable>, Type>(delegate(Type type) {
                return variable_providers.FindFirstNonEmpty(z => z.GetDesignatedVariables(type))
                    .ToDictionaryValues(z => z.GetVariableName());
            });
        }

        public TyonSerializer(IEnumerable<TyonSerializerComponent> c) : this(c.Convert<TyonSerializerComponent, TyonBridge>(), c.Convert<TyonSerializerComponent, TyonDesignatedVariableProvider>()) { }
        public TyonSerializer(params TyonSerializerComponent[] c) : this((IEnumerable<TyonSerializerComponent>)c) { }

        public string Serialize(object obj)
        {
            return new TyonContext_Dehydration(this).Dehydrate(obj).Render();
        }
        public string Serialize(object obj, IList<object> output_registered_external_objects)
        {
            string output;
            TyonContext_Dehydration context = new TyonContext_Dehydration(this);

            output = context.Dehydrate(obj).Render();
            output_registered_external_objects.Set(context.GetRegisteredExternalObjects());

            return output;
        }

        public object Deserialize(string text)
        {
            return new TyonContext_Hydration(this).Hydrate(TyonObject.DOMify(text));
        }
        public object Deserialize(string text, IEnumerable<object> external_objects)
        {
            TyonContext_Hydration context = new TyonContext_Hydration(this);

            context.RegisterExternalObjects(external_objects);
            return context.Hydrate(TyonObject.DOMify(text));
        }

        public T Deserialize<T>(string text)
        {
            return Deserialize(text).Convert<T>();
        }
        public T Deserialize<T>(string text, IEnumerable<object> external_objects)
        {
            return Deserialize(text, external_objects).Convert<T>();
        }

        public void DeserializeInto(string text, object obj)
        {
            new TyonContext_Hydration(this).HydrateInto(obj, TyonObject.DOMify(text));
        }
        public void DeserializeInto(string text, object obj, IEnumerable<object> external_objects)
        {
            TyonContext_Hydration context = new TyonContext_Hydration(this);

            context.RegisterExternalObjects(external_objects);
            context.HydrateInto(obj, TyonObject.DOMify(text));
        }

        public string SerializeValue(object value, Type type)
        {
            return new TyonContext_Dehydration(this).DehydrateValue(value, type).Render();
        }
        public string SerializeValue(object value, Type type, IList<object> output_registered_external_objects)
        {
            string output;
            TyonContext_Dehydration context = new TyonContext_Dehydration(this);

            output = context.DehydrateValue(value, type).Render();
            output_registered_external_objects.Set(context.GetRegisteredExternalObjects());

            return output;
        }

        public object DeserializeValue(string text, Type type)
        {
            return new TyonContext_Hydration(this).HydrateValue(TyonValue.DOMify(text), type);
        }
        public object DeserializeValue(string text, Type type, IEnumerable<object> external_objects)
        {
            TyonContext_Hydration context = new TyonContext_Hydration(this);

            context.RegisterExternalObjects(external_objects);
            return context.HydrateValue(TyonValue.DOMify(text), type);
        }

        public TyonBridge GetBridge(Variable variable)
        {
            return bridges_cache.Fetch(variable);
        }

        public IEnumerable<Variable> GetDesignatedVariables(Type type)
        {
            return designated_variables_cache.Fetch(type).Values;
        }

        public bool TryGetDesignatedVariable(Type type, string name, out Variable variable)
        {
            return designated_variables_cache.Fetch(type).TryGetValue(name, out variable);
        }
    }
}
