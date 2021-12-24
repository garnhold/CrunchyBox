
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: March 02 2019 21:52:08 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonSurrogate : TyonElement
	{
        public TyonSurrogate(object value, TyonDehydrater dehydrater) : this()
        {
            SetTyonType(TyonType.CreateTyonType(value.GetTypeEX()));
            SetTyonValue(new TyonValue_String(value, dehydrater));
        }

        public object ResolveSystemObject(TyonHydrater hydrater)
        {
            return hydrater.HydrateValue(
                GetTyonType().GetSystemType(hydrater), 
                GetTyonValue()
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
            canvas.AppendToLine("$");
            GetTyonType().Render(canvas);
            canvas.AppendToLine(":");
            GetTyonValue().Render(canvas);
        }

        public override string ToString()
        {
            return Render();
        }
	}
	
}
