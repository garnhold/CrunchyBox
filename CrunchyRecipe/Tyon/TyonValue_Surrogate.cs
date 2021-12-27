
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: March 02 2019 21:52:08 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonValue_Surrogate : TyonValue
	{
        public TyonValue_Surrogate(object value, TyonDehydrater dehydrater) : this()
        {
            SetTyonSurrogate(new TyonSurrogate(value, dehydrater));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonSurrogate().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetTyonSurrogate().InstanceSystemObject(hydrater));
        }
	}
	
}
