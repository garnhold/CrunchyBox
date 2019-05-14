
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/7/2017 9:17:20 PM

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonValue_Null : TyonValue
	{
        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("null");
        }

        public override void PushToVariable(VariableInstance variable, TyonContext_Hydration context)
        {
            variable.SetContents(null);
        }
	}
	
}
