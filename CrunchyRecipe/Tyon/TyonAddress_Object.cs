
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
	public partial class TyonAddress_Object : TyonAddress
	{
        public TyonAddress_Object(object o, TyonDehydrater dehydrater) : this()
        {
            SetTyonObject(dehydrater.GetContext().CreateDehydrater().Dehydrate(o));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonObject().Render(canvas);
        }

        public override object GetAddressValue(TyonHydrater hydrater)
        {
            return hydrater.CreateHydrater().Hydrate(GetTyonObject());
        }
	}
	
}
