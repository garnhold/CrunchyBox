
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
        public TyonValue_Surrogate(object value, TyonContext_Dehydration context) : this()
        {
            SetTyonSurrogate(new TyonSurrogate(value, context));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonSurrogate().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonContext_Hydration context)
        {
            object value = GetTyonSurrogate().InstanceSystemObject(context);

            context.DeferProcess(delegate() {
                variable.SetContents(value);
            });
        }
	}
	
}
