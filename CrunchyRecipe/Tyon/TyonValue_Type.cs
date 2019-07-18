
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: July 17 2019 11:47:14 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonValue_Type : TyonValue
	{
        public TyonValue_Type(Type value, TyonContext_Dehydration context) : this()
        {
            SetTyonType(TyonType.CreateTyonType(value));
        }

        public TyonValue_Type(VariableInstance variable, TyonContext_Dehydration context) : this(variable.GetContents<Type>(), context) { }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("typeof(");
                GetTyonType().Render(canvas);
            canvas.AppendToLine(")");
        }

        public override void PushToVariable(VariableInstance variable, TyonContext_Hydration context)
        {
            variable.SetContents(GetTyonType().GetSystemType());
        }
	}
	
}
