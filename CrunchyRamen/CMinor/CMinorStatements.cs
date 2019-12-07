
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: October 14 2019 1:47:36 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorStatements : CMinorElement
	{
        public ILStatement Compile(CMinorEnvironment environment)
        {
            return new ILBlock(
                GetCMinorStatements().Convert(s => s.Compile(environment))
            );
        }
	}
	
}
