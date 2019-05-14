
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
        public TyonValue_ExternalAddress(object a, TyonContext_Dehydration context) : this()
        {
            SetTyonAddress(context.CreateTyonAddress(a));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("@");
            GetTyonAddress().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonContext_Hydration context)
        {
            context.DeferProcess(delegate() {
                variable.SetContents(context.ResolveExternalAddress(GetTyonAddress(), variable.GetVariable()));
            });
        }
	}
	
}
