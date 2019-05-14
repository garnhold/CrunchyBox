
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: February 28 2019 23:32:29 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonAddress_Identifier : TyonAddress
	{
        public TyonAddress_Identifier(string i, TyonContext_Dehydration context) : this()
        {
            SetId(i);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetId());
        }

        public override object GetAddressValue(TyonContext_Hydration context)
        {
            return GetId();
        }
	}
	
}
