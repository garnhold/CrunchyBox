
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:02:54 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRamen
{
	public partial class CMinorExpressionList : CMinorElement
	{
        public IEnumerable<ILValue> CompileAsValues(CMinorEnvironment environment)
        {
            return GetCMinorExpressions().Convert(e => e.CompileAsValue(environment));
        }
	}
	
}
