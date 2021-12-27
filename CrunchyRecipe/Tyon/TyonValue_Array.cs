
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonValue_Array : TyonValue
    {
        public TyonValue_Array(Type element_type, object value, TyonDehydrater dehydrater) : this()
        {
            SetTyonArray(new TyonArray(element_type, value, dehydrater));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonArray().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            GetTyonArray().PushToVariable(variable, hydrater);
        }
    }

}
