
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonValue_Number : TyonValue
	{
        public TyonValue_Number(object value, TyonDehydrater dehydrater) : this()
        {
            SetNumber(value.ToString().ParseNumber());
        }

        public TyonValue_Number(VariableInstance variable, TyonDehydrater dehydrater) : this(variable.GetContents(), dehydrater) { }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetNumber());
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetNumber());
        }
	}
	
}
