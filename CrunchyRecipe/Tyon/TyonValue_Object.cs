
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonValue_Object : TyonValue
	{
        public TyonValue_Object(object value, TyonDehydrater dehydrater) : this()
        {
            SetTyonObject(new TyonObject(value, dehydrater));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonObject().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            GetTyonObject().PushToVariable(variable, hydrater);
        }

        public override void CompileInitialize(TyonCompiler compiler)
        {
            GetTyonObject().CompileInitialize(compiler);
        }

        public override ILValue CompileValue(TyonCompiler compiler)
        {
            return GetTyonObject().CompileLocal(compiler);
        }
    }
}
