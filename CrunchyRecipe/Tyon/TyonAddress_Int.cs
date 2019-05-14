
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
	public partial class TyonAddress_Int : TyonAddress
	{
        public TyonAddress_Int(int n, TyonContext_Dehydration context) : this()
        {
            SetNumber(n);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetNumber().ToString());
        }

        public override object GetAddressValue(TyonContext_Hydration context)
        {
            return GetNumber();
        }
	}
	
}
