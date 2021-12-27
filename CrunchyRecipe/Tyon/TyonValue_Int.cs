
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
	public partial class TyonValue_Int : TyonValue
	{
        public TyonValue_Int(object value, TyonDehydrater dehydrater) : this()
        {
            SetInt(value.ConvertEX<int>());
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetInt().StyleAsLiteral());
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetInt());
        }
    }
	
}
