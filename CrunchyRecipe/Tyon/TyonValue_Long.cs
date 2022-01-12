
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
	public partial class TyonValue_Long : TyonValue
	{
        public TyonValue_Long(object value, TyonDehydrater dehydrater) : this()
        {
            SetLong(value.ConvertEX<long>());
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetLong().StyleAsLiteral());
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetLong());
        }

        public override ILValue CompileValue(TyonCompiler compiler)
        {
            return GetLong();
        }
    }
	
}
