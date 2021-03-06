
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
    
    public partial class CMinorTypeList : CMinorElement
	{
        public IEnumerable<Type> GetSystemTypes(CMinorEnvironment environment)
        {
            return GetCMinorTypes().Convert(t => t.GetSystemType(environment));
        }
	}
	
}
