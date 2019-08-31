
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: March 02 2019 21:52:08 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonValue_Surrogate : TyonValue
	{
        public TyonValue_Surrogate(Type type, object surrogate, TyonDehydrater dehydrater) : this()
        {
            SetTyonSurrogate(new TyonSurrogate(type, surrogate, dehydrater));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonSurrogate().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            object value = GetTyonSurrogate().ResolveSystemObject(hydrater);

            hydrater.DeferProcess(delegate() {
                variable.SetContents(value);
            });
        }
	}
	
}
