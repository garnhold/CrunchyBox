
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: February 28 2019 23:37:18 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonValue_InternalAddress : TyonValue
	{
        public TyonValue_InternalAddress(object a, TyonDehydrater dehydrater) : this()
        {
            SetTyonAddress(dehydrater.CreateTyonAddress(a));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("&");
            GetTyonAddress().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            hydrater.DeferProcess(delegate() {
                variable.SetContents(hydrater.ResolveInternalAddress(GetTyonAddress()));
            });
        }
	}
	
}
