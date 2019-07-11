
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
	public partial class TyonVariable : TyonElement
	{
        public TyonVariable(VariableInstance variable, TyonContext_Dehydration context) : this()
        {
            SetId(variable.GetVariable().GetVariableName());
            SetTyonValue(context.CreateTyonValue(variable));
        }

        public void PushToSystemObject(object obj, TyonContext_Hydration context)
        {
            Variable variable;

            if (context.TryGetDesignatedVariable(obj.GetType(), GetId(), out variable))
                GetTyonValue().PushToVariable(variable.CreateStrongInstance(obj), context);
        }

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }

        public void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToNewline(GetId());
            canvas.AppendToLine(" = ");
            GetTyonValue().Render(canvas);
            canvas.AppendToLine(";");
        }
	}
	
}
