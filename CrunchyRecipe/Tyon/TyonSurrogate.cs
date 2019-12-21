
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
        private void LoadContextIntermediateString(string input)
        {
            SetString(input.ExtractStringValueFromLiteralString());
        }

        public TyonSurrogate(object value, TyonDehydrater dehydrater) : this()
        {
            SetTyonType(TyonType.CreateTyonType(value.GetTypeEX()));
            SetString(value.ConvertEX<string>());
        }

        public object ResolveSystemObject(TyonHydrater hydrater)
        {
            return GetString().ConvertEX(GetTyonType().GetSystemType(hydrater)) ??
                GetTyonType().InstanceSystemType(hydrater);
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
            canvas.AppendToLine(GetString().StyleAsDoubleQuoteLiteral());
        }

        public override string ToString()
        {
            return Render();
        }
	}
	
}
