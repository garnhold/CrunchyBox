
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: February 28 2019 23:41:22 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonAddress_String : TyonAddress
	{
        private void LoadContextIntermediateString(string input)
        {
            SetString(input.ExtractStringValueFromLiteralString());
        }

        public TyonAddress_String(string s, TyonDehydrater dehydrater) : this()
        {
            SetString(s);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetString().StyleAsLiteralString());
        }

        public override object GetAddressValue(TyonHydrater hydrater)
        {
            return GetString();
        }
	}
	
}
