using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonSettings
    {
        private List<TyonTypeHandler> type_handlers;
        private List<TyonDesignatedVariableProvider> variable_providers;

        private OperationCache<TyonTypeHandler, Type> type_handler_cache;
        private OperationCache<Dictionary<string, Variable>, Type> designated_variables_cache;

        public TyonSettings(IEnumerable<TyonTypeHandler> t, IEnumerable<TyonDesignatedVariableProvider> v)
        {
            type_handlers = t.Prepend(
                TyonTypeHandler_Integer.INSTANCE,
                TyonTypeHandler_Boolean.INSTANCE,
                TyonTypeHandler_Real.INSTANCE,
                TyonTypeHandler_String.INSTANCE,
                TyonTypeHandler_Enum.INSTANCE,
                TyonTypeHandler_IEnumerable.INSTANCE,
                TyonTypeHandler_Type.INSTANCE
            ).Append(
                TyonTypeHandler_Object.INSTANCE,
                TyonTypeHandler_Fallback.INSTANCE
            ).ToList();
            type_handlers.Process(z => z.SetSettings(this));

            variable_providers = v.ToList();
            variable_providers.Process(z => z.SetSettings(this));

            type_handler_cache = new OperationCache<TyonTypeHandler, Type>("type_handler_cache", delegate(Type type) {
                return type_handlers.FindFirst(z => z.IsCompatible(type));
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

        public TyonTypeHandler GetTypeHandler(Type type)
        {
            return type_handler_cache.Fetch(type);
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
