
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonObject : TyonElement, TyonAddressable
	{
        public TyonObject(object obj, TyonDehydrater dehydrater) : this()
        {
            dehydrater.RegisterInternalObject(obj, this);

            SetTyonType(TyonType.CreateTyonType(obj.GetType()));
            SetTyonVariables(
                dehydrater.GetDesignatedVariables(obj.GetType())
                    .Convert(v => new TyonVariable(v.CreateStrongInstance(obj), dehydrater))
            );
        }

        public object InstanceSystemObject(TyonHydrater hydrater)
        {
            object system_object = null;

            if (GetTyonValueList() != null)
            {
                Variable_IndexedLog log = Variable_IndexedLog.New(typeof(object));

                if (GetTyonValueList().PushToLogVariable(log, hydrater) != TyonPushResult.Done)
                    throw new TyonResolutionException("A constructor cannot depend on a deferred value.");

                system_object = GetTyonType().InstanceSystemObject(hydrater, log.GetValues().ToArray());
            }
            else
            {
                system_object = GetTyonType().InstanceSystemObject(hydrater);
            }

            return system_object.ChainIfNotNull(o => PushToSystemObject(o, hydrater));
        }
        public void PushToSystemObject(object obj, TyonHydrater hydrater)
        {
            hydrater.RegisterInternalAddress(obj, GetTyonAddress());
            GetTyonVariables().Process(v => v.PushToSystemObject(obj, hydrater));
        }

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }

        public void Render(TextDocumentCanvas canvas)
        {
            GetTyonType().Render(canvas);

            if (GetTyonAddress() != null)
            {
                canvas.AppendToLine("&");
                GetTyonAddress().Render(canvas);
            }

            if (GetTyonValueList() != null)
            {
                canvas.AppendToLine("(");
                GetTyonValueList().Render(canvas, false);
                canvas.AppendToLine(")");
            }

            if (GetTyonVariables().IsNotEmpty())
            {
                canvas.AppendToLine(" {");
                canvas.Indent();
                    GetTyonVariables().Process(v => v.Render(canvas));
                canvas.Dedent();
                canvas.AppendToNewline("}");
            }
        }

        public TyonPushResult PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            if (AllowsHotloading() && variable.GetVariableType().IsTypicalReferenceType())
            {
                object current_value = variable.GetContents();

                if (current_value != null)
                {
                    if (GetSystemType(hydrater) == current_value.GetType())
                    {
                        PushToSystemObject(current_value, hydrater);
                        return TyonPushResult.Done;
                    }
                }
            }

            variable.SetContents(InstanceSystemObject(hydrater));
            return TyonPushResult.Done;
        }

        public void CompileInitialize(TyonCompiler compiler)
        {
            ILLocal local = compiler.ResolveObject(this);

            if (local == null && GetTyonValueList() == null)
            {
                local = compiler.DefineLocal(
                    this, 
                    GetTyonType().CompileInstanceSystemObject(compiler)
                );
            }

            GetTyonValueList().IfNotNull(l => l.CompileInitialization(compiler));
            GetTyonVariables().Process(v => v.CompileInitialize(compiler));
        }
        public ILLocal CompileLocal(TyonCompiler compiler)
        {
            ILLocal local = compiler.ResolveObject(this);

            if (local == null)
            {
                local = compiler.DefineLocal(
                    this, 
                    GetTyonType().CompileInstanceSystemObject(compiler, GetTyonValueList().CompileValues(compiler))
                );
            }

            CompilePushToSystemObject(local, compiler);
            return local;
        }
        public void CompilePushToSystemObject(ILLocal obj, TyonCompiler compiler)
        {
            GetTyonVariables().Process(v => v.CompilePushToSystemObject(obj, compiler));
        }

        public TyonAddress RequestAddress(TyonDehydrater dehydrater)
        {
            if (GetTyonAddress() == null)
                SetTyonAddress(dehydrater.GetNewInternalAddress());

            return GetTyonAddress();
        }

        public bool AllowsHotloading()
        {
            if (GetTyonValueList() == null)
                return true;

            return false;
        }

        public Type GetSystemType(TyonHydrater hydrater)
        {
            return GetTyonType().GetSystemType(hydrater);
        }

        public override string ToString()
        {
            return Render();
        }
	}
	
}
