
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: August 31 2019 21:14:23 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonValue_Int : TyonValue
	{
        public TyonValue_Int(object value, TyonDehydrater dehydrater) : this()
        {
            SetInt(value.ConvertEX<long>());
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetInt().ToString());
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetInt());
        }
	}
	
}
