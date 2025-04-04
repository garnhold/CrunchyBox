
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: October 26 2017 21:52:03 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonValue_ExternalAddress : TyonValue
	{
        public TyonValue_ExternalAddress(TyonAddress a, TyonDehydrater dehydrater) : this()
        {
            SetTyonAddress(a);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("@");
            GetTyonAddress().Render(canvas);
        }

        public override TyonPushResult PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(hydrater.ResolveExternalAddress(GetTyonAddress()));

            return TyonPushResult.Done;
        }

        public override ILValue CompileValue(TyonCompiler compiler)
        {
            return compiler.ResolveExternalAddress(GetTyonAddress());
        }
    }
	
}
