
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: June 29 2019 15:40:47 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cheese
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class MExpFunction : MExpElement
	{
        public ILValue GetILValue()
        {
            return MarkedMethods<MExpFunctionAttribute>.GetFilteredMarkedStaticMethods(
                Filterer_MethodInfo.IsNamed(GetId())
            )
            .GetFirst()
            .GetStaticILMethodInvokation(
                GetMExpExpressions().Convert(e => e.GetILValue())
            );
        }
	}
	
}
