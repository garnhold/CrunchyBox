using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonSettings
    {
        private List<TyonTypeHandler> type_handlers;
        private List<TyonTypeDehydrater> type_dehydraters;
        private List<TyonTypeResolver> type_resolvers;

        private List<TyonDesignatedVariableProvider> variable_providers;

        private OperationCache<TyonTypeDehydrater, Type> type_dehydrater_cache;
        private OperationCache<TyonTypeResolver, Type> type_resolver_cache;
        private OperationCache<Dictionary<string, Variable>, Type> designated_variables_cache;

        public TyonSettings(IEnumerable<TyonTypeHandler> t, IEnumerable<TyonDesignatedVariableProvider> v)
        {
            type_handlers = t.Prepend(
                TyonTypeHandler_String.INSTANCE,
                TyonTypeHandler_Number.INSTANCE,
                TyonTypeHandler_Enum.INSTANCE,
                TyonTypeHandler_IEnumerable.INSTANCE,
                TyonTypeHandler_Object.INSTANCE
            ).Append(
                TyonTypeHandler_Surrogate_Default.INSTANCE
            ).ToList();
            type_handlers.Process(z => z.SetSettings(this));

            type_dehydraters = type_handlers.Convert<TyonTypeHandler, TyonTypeDehydrater>().ToList();
            type_resolvers = type_handlers.Convert<TyonTypeHandler, TyonTypeResolver>().ToList();

            variable_providers = v.ToList();
            variable_providers.Process(z => z.SetSettings(this));

            type_dehydrater_cache = new OperationCache<TyonTypeDehydrater, Type>("type_dehydrater_cache", delegate(Type type) {
                return type_dehydraters.FindFirst(z => z.IsDehydrater(type));
            });

            type_resolver_cache = new OperationCache<TyonTypeResolver, Type>("type_resolver_cache", delegate(Type type) {
                return type_resolvers.FindFirst(z => z.IsResolver(type));
            });

            designated_variables_cache = new OperationCache<Dictionary<string, Variable>, Type>("designated_variables_cache", delegate(Type type) {
                return variable_providers.FindFirstNonEmpty(z => z.GetDesignatedVariables(type))
                    .ToDictionaryValues(z => z.GetVariableName());
            });
        }

        public TyonSettings(IEnumerable<TyonSettingsComponent> c) : this(c.Convert<TyonSettingsComponent, TyonTypeHandler>(), c.Convert<TyonSettingsComponent, TyonDesignatedVariableProvider>()) { }
        public TyonSettings(params TyonSettingsComponent[] c) : this((IEnumerable<TyonSettingsComponent>)c) { }

        public TyonContext CreateContext()
        {
            return new TyonContext(this);
        }

        public TyonContext CreateContext(IEnumerable<object> external_objects)
        {
            TyonContext context = CreateContext();

            context.RegisterExternalObjects(external_objects);
            return context;
        }

        public TyonTypeDehydrater GetTypeDehydrater(Type type)
        {
            return type_dehydrater_cache.Fetch(type);
        }

        public TyonTypeResolver GetTypeResolver(Type type)
        {
            return type_resolver_cache.Fetch(type);
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
