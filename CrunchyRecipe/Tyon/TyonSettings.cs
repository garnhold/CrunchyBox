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
        private List<TyonBridge> bridges;
        private List<TyonDesignatedVariableProvider> variable_providers;

        private OperationCache<TyonBridge, Variable> bridges_cache;
        private OperationCache<Dictionary<string, Variable>, Type> designated_variables_cache;

        public TyonSettings(IEnumerable<TyonBridge> b, IEnumerable<TyonDesignatedVariableProvider> v)
        {
            bridges = b.ToList();
            bridges.Process(z => z.SetSettings(this));

            variable_providers = v.ToList();
            variable_providers.Process(z => z.SetSettings(this));

            bridges_cache = new OperationCache<TyonBridge, Variable>("bridges_cache", delegate(Variable variable) {
                return bridges.FindFirst(z => z.IsCompatible(variable)) ?? TyonBridge_Default.INSTANCE;
            });

            designated_variables_cache = new OperationCache<Dictionary<string, Variable>, Type>("designated_variables_cache", delegate(Type type) {
                return variable_providers.FindFirstNonEmpty(z => z.GetDesignatedVariables(type))
                    .ToDictionaryValues(z => z.GetVariableName());
            });
        }

        public TyonSettings(IEnumerable<TyonSettingsComponent> c) : this(c.Convert<TyonSettingsComponent, TyonBridge>(), c.Convert<TyonSettingsComponent, TyonDesignatedVariableProvider>()) { }
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
