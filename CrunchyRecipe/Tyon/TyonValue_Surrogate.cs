
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

        public override TyonPushResult PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            return GetTyonSurrogate().PushToVariable(variable, hydrater);
        }

        public override void CompileInitialize(TyonCompiler compiler)
        {
            GetTyonSurrogate().CompileInitialize(compiler);
        }

        public override ILValue CompileValue(TyonCompiler compiler)
        {
            return GetTyonSurrogate().CompileValue(compiler);
        }
    }
	
}
