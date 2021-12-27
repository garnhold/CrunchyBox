
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
	public partial class TyonValue_Double : TyonValue
	{
        public TyonValue_Double(object value, TyonDehydrater dehydrater) : this()
        {
            SetDouble(value.ConvertEX<double>());
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetDouble().StyleAsLiteral());
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetDouble());
        }
    }
	
}
