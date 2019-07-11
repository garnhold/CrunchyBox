
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonValue_String : TyonValue
	{
        private void LoadContextIntermediateString(string input)
        {
            SetString(input.ExtractStringValueFromLiteralString());
        }

        public TyonValue_String(object value, TyonContext_Dehydration context) : this()
        {
            SetString(value.ToString());
        }

        public TyonValue_String(VariableInstance variable, TyonContext_Dehydration context) : this(variable.GetContents(), context) { }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetString().StyleAsLiteralString());
        }

        public override void PushToVariable(VariableInstance variable, TyonContext_Hydration context)
        {
            variable.SetContents(GetString());
        }
	}
	
}
