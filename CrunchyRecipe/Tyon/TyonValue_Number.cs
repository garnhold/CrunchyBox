
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
        public TyonValue_Number(object value, TyonContext_Dehydration context) : this()
        {
            SetNumber(value.ToString().ParseNumber());
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetNumber());
        }

        public override void PushToVariable(VariableInstance variable, TyonContext_Hydration context)
        {
            variable.SetContents(GetNumber());
        }
	}
	
}
