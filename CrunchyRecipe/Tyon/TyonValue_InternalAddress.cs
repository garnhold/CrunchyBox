
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: February 28 2019 23:37:18 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonValue_InternalAddress : TyonValue
	{
        public TyonValue_InternalAddress(TyonAddress address, TyonDehydrater dehydrater) : this()
        {
            SetTyonAddress(address);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("&");
            GetTyonAddress().Render(canvas);
        }

        public override TyonPushResult PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            if (hydrater.TryResolveInternalAddress(GetTyonAddress(), out object obj))
            {
                variable.SetContents(obj);
                return TyonPushResult.Done;
            }

            hydrater.DeferProcess(delegate() {
                variable.SetContents(hydrater.ResolveInternalAddress(GetTyonAddress()));
            });

            return TyonPushResult.Deferred;
        }

        public override ILValue CompileValue(TyonCompiler compiler)
        {
            return compiler.ResolveInternalAddress(GetTyonAddress());
        }
    }
	
}
