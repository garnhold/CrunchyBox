
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: August 31 2019 21:14:23 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonValue_Integer : TyonValue
	{
        public TyonValue_Integer(object value, TyonDehydrater dehydrater) : this()
        {
            SetInteger(value.ConvertEX<long>());
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToLine(GetInteger().ToString());
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            variable.SetContents(GetInteger());
        }
	}
	
}
