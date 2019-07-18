using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public class TyonContext_Hydration : TyonContext
	{
        private List<Process> deferred_processes;
        private Dictionary<object, object> internal_address_to_object;

        private void Finish()
        {
            deferred_processes.Process(p => p());
            Clear();
        }

        public TyonContext_Hydration(TyonSerializer s) : base(s)
        {
            deferred_processes = new List<Process>();
            internal_address_to_object = new Dictionary<object, object>();
        }

        public void Clear()
        {
            deferred_processes.Clear();
            internal_address_to_object.Clear();
        }

        public object Hydrate(TyonObject tyon_object)
        {
            object obj = tyon_object.InstanceSystemObject(this);

            Finish();
            return obj;
        }

        public void HydrateInto(object obj, TyonObject tyon_object)
        {
            tyon_object.PushToSystemObject(obj, this);
            Finish();
        }

        public object HydrateValue(TyonValue tyon_value, Type type)
        {
            VariableInstance variable = new Variable_Static_Value("value", type, null)
                .CreateInstance();

            tyon_value.PushToVariable(variable, this);
            Finish();

            return variable.GetContents();
        }

        public void RegisterInternalObject(object obj, TyonAddress address)
        {
            if (address != null)
                internal_address_to_object.Add(address.GetAddressValue(this), obj);
        }

        public bool TryResolveInternalAddress(TyonAddress address, out object obj)
        {
            return internal_address_to_object.TryGetValue(address.GetAddressValue(this), out obj);
        }
        public object ResolveInternalAddress(TyonAddress address)
        {
            object obj;

            TryResolveInternalAddress(address, out obj);
            return obj;
        }

        public object ResolveExternalAddress(TyonAddress address, Variable variable)
        {
            return GetBridge(variable).ResolveTyonAddress(address, variable, this);
        }

        public void DeferProcess(Process process)
        {
            deferred_processes.Add(process);
        }

        public bool TryGetDesignatedVariable(Type type, string name, out Variable variable)
        {
            return GetSerializer().TryGetDesignatedVariable(type, name, out variable);
        }
	}
	
}