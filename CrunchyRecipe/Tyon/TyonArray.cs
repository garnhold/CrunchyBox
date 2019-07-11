
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: October 09 2017 18:07:15 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonArray : TyonElement
	{
        public TyonArray(VariableInstance variable, TyonContext_Dehydration context) : this()
        {
            SetTyonType(TyonType.CreateTyonType(variable.GetVariable().GetVariableElementType()));
            SetTyonValues(
                variable.GetAllVariableInstanceElements().Convert(v => context.CreateTyonValue(v))
            );
        }

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }

        public void Render(TextDocumentCanvas canvas)
        {
            GetTyonType().Render(canvas);
            canvas.AppendToLine(" [");
            canvas.Indent();
                canvas.AppendNewline();
                GetTyonValues().ProcessWithInterleaving(v => v.Render(canvas), () => { canvas.AppendToLine(","); canvas.AppendNewline(); });
            canvas.Dedent();
            canvas.AppendToNewline("]");
        }

        public int GetNumberTyonValues()
        {
            return tyon_values.Count;
        }
	}
	
}
