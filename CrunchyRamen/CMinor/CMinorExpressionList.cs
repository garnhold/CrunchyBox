
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:02:54 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorExpressionList : CMinorElement
	{
        public IEnumerable<ILValue> CompileAsValues(CMinorEnvironment environment)
        {
            return GetCMinorExpressions().Convert(e => e.CompileAsValue(environment));
        }
	}
	
}
