
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: October 26 2017 21:52:03 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonValue_ExternalAddress : TyonValue
	{
        public TyonValue_ExternalAddress(TyonAddress a, TyonDehydrater dehydrater) : this()
        {
            SetTyonAddress(a);
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("@");
            GetTyonAddress().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            hydrater.DeferProcess(delegate() {
                variable.SetContents(hydrater.ResolveExternalAddress(GetTyonAddress()));
            });
        }
	}
	
}
