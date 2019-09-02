
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
	public partial class TyonAddress_Integer : TyonAddress
	{
        public TyonAddress_Integer(long n, TyonDehydrater dehydrater) : this()
        {
            SetInteger(n);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetInteger().ToString());
        }

        public override object GetSystemValue()
        {
            return GetInteger();
        }
	}
	
}
