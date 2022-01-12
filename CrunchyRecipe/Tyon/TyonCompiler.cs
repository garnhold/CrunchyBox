using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class TyonCompiler : TyonHydraterBase
	{
        private ILBlock block;

        private Dictionary<TyonObject, ILLocal> object_to_local;
        private Dictionary<TyonAddress, ILLocal> internal_address_to_local;
        private Dictionary<TyonAddress, ILVirtualParameter> external_address_to_virtual_parameter;

        public TyonCompiler(TyonHydrationMode m, TyonContext c) : base(m, c)
        {
            block = new ILBlock();

            object_to_local = new Dictionary<TyonObject, ILLocal>();
            internal_address_to_local = new Dictionary<TyonAddress, ILLocal>();
            external_address_to_virtual_parameter = new Dictionary<TyonAddress, ILVirtualParameter>();
        }

        public Operation<object> CompilePushToSystemObject(TyonObject tyon_object)
        {
            return this.GetType().CreateDynamicMethodDelegate<Operation<object>>(delegate (ILValue target) {
                tyon_object.CompileInitialize(this);
                tyon_object.CompilePushToSystemObject(target, this);

                return block;
            });
        }

        public ILLocal DefineLocal(TyonObject obj, ILValue value)
        {
            ILLocal local = block.CreateCementedLocal(value);

            object_to_local.Add(obj, local);

            if (obj.GetTyonAddress() != null)
                internal_address_to_local.Add(obj.GetTyonAddress(), local);

            return local;
        }

        public void AddStatement(ILStatement statement)
        {
            block.AddStatement(statement);
        }

        public ILLocal ResolveObject(TyonObject obj)
        {
            return object_to_local.GetValue(obj);
        }

        public ILLocal ResolveInternalAddress(TyonAddress address)
        {
            return internal_address_to_local.GetValue(address);
        }
        public ILVirtualParameter ResolveExternalAddress(TyonAddress address)
        {
            return external_address_to_virtual_parameter.GetValue(address);
        }
    }
	
}