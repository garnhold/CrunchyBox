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
        private ILValue context;

        private Dictionary<TyonObject, ILLocal> object_to_local;
        private Dictionary<TyonAddress, ILLocal> internal_address_to_local;

        public TyonCompiler(TyonHydrationMode m, TyonContext c) : base(m, c)
        {
            object_to_local = new Dictionary<TyonObject, ILLocal>();
            internal_address_to_local = new Dictionary<TyonAddress, ILLocal>();
        }

        public Operation<object, TyonContext> CompileInstanceSystemObject(TyonObject tyon_object)
        {
            return this.GetType().CreateDynamicMethodDelegate<Operation<object, TyonContext>>(delegate (ILValue c) {
                block = new ILBlock();
                context = c;

                tyon_object.CompileInitialize(this);
                ILLocal local = tyon_object.CompileLocal(this);

                block.AddStatement(new ILReturn(local));
                return block;
            });
        }
        public Operation<object, TyonContext> CompileInstanceSystemObject(string text)
        {
            return CompileInstanceSystemObject(TyonObject.DOMify(text));
        }

        public Process<object, TyonContext> CompilePushToSystemObject(TyonObject tyon_object)
        {
            return this.GetType().CreateDynamicMethodDelegate<Process<object, TyonContext>>(delegate (ILValue t, ILValue c) {
                block = new ILBlock();
                context = c;

                tyon_object.CompileInitialize(this);
                tyon_object.CompilePushToSystemObject(t, this);

                return block;
            });
        }
        public Process<object, TyonContext> CompilePushToSystemObject(string text)
        {
            return CompilePushToSystemObject(TyonObject.DOMify(text));
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
        public ILValue ResolveExternalAddress(TyonAddress address)
        {
            return context.GetInstanceILMethodInvokation("ResolveExternalAddress", address.CreateILLiteral());
        }
    }
	
}