
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: August 30 2019 23:36:10 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonValue_Type : TyonValue
	{
        public TyonValue_Type(Type type, TyonDehydrater dehydrater)
        {
            SetTyonType(TyonType.CreateTyonType(type));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine("typeof(");
                GetTyonType().Render(canvas);
            canvas.AppendToLine(")");
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetTyonType().GetSystemType(hydrater));
        }

        public override ILValue CompileValue(TyonCompiler compiler)
        {
            return GetTyonType().GetSystemType(compiler);
        }
    }
	
}
