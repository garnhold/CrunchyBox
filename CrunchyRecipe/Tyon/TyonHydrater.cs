using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonHydrater : TyonHydraterBase
	{
        private DeferredProcessList deferred_process_list;
        private Dictionary<TyonAddress, object> internal_address_to_object;

        private void Finish()
        {
            deferred_process_list.ProcessDeferred();
        }

        public TyonHydrater(TyonHydrationMode m, TyonContext c) : base(m, c)
        {
            deferred_process_list = new DeferredProcessList();
            internal_address_to_object = new Dictionary<TyonAddress, object>();
        }

        public object Hydrate(TyonObject tyon_object)
        {
            object obj = tyon_object.InstanceSystemObject(this);

            Finish();
            return obj;
        }
        public object Hydrate(string text)
        {
            return Hydrate(TyonObject.DOMify(text));
        }

        public void HydrateInto(object obj, TyonObject tyon_object)
        {
            tyon_object.PushToSystemObject(obj, this);
            Finish();
        }
        public void HydrateInto(object obj, string text)
        {
            HydrateInto(obj, TyonObject.DOMify(text));
        }

        public object HydrateValue(Type type, TyonValue tyon_value)
        {
            VariableInstance variable = new Variable_Static_Value("value", type, null)
                .CreateInstance();

            tyon_value.PushToVariable(variable, this);
            Finish();

            return variable.GetContents();
        }
        public object HydrateValue(Type type, string text)
        {
            return HydrateValue(type, TyonValue.DOMify(text));
        }

        public object ResolveExternalAddress(TyonAddress address)
        {
            return GetContext().ResolveExternalAddress(address);
        }

        public void RegisterInternalAddress(object obj, TyonAddress address)
        {
            if (address != null)
                internal_address_to_object.Add(address, obj);
        }

        public bool TryResolveInternalAddress(TyonAddress address, out object obj)
        {
            return internal_address_to_object.TryGetValue(address, out obj);
        }
        public object ResolveInternalAddress(TyonAddress address)
        {
            object obj;

            TryResolveInternalAddress(address, out obj);
            return obj;
        }

        public void DeferProcess(Process process)
        {
            deferred_process_list.Defer(process);
        }
    }
	
}