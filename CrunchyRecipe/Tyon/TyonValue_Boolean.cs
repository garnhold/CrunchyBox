
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: June 23 2020 13:57:55 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;

	public partial class TyonValue_Boolean : TyonValue
	{
        public TyonValue_Boolean(object value, TyonDehydrater dehydrater) : this()
        {
            SetBool(value.ConvertEX<bool>());
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetBool().StyleAsLiteral());
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetBool());
        }
    }
	
}
