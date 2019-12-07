
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: October 09 2017 18:07:15 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonArray : TyonElement
	{
        public TyonArray(Type element_type, object value, TyonDehydrater dehydrater) : this()
        {
            SetTyonType(TyonType.CreateTyonType(element_type));
            SetTyonValues(
                value.ToEnumerable<object>().Convert(v => dehydrater.CreateTyonValue(element_type, v))
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

        public override string ToString()
        {
            return Render();
        }
	}
	
}
