
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/7/2017 9:17:20 PM

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonValue_Null : TyonValue
	{
        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("null");
        }

        public override TyonPushResult PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(null);

            return TyonPushResult.Done;
        }

        public override ILValue CompileValue(TyonCompiler compiler)
        {
            return ILNull.INSTANCE;
        }
    }
	
}
