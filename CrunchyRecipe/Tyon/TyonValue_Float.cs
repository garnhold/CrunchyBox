
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: December 27 2021 1:49:43 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

namespace Crunchy.Recipe
{
	public partial class TyonValue_Float : TyonValue
	{
        public TyonValue_Float(object value, TyonDehydrater dehydrater) : this()
        {
            SetFloat(value.ConvertEX<float>());
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetFloat().StyleAsLiteral());
        }

        public override TyonPushResult PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetFloat());

            return TyonPushResult.Done;
        }

        public override ILValue CompileValue(TyonCompiler compiler)
        {
            return GetFloat();
        }
    }
	
}
