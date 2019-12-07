
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: September 06 2019 15:15:13 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Ramen
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CMinorType_Normal : CMinorType
	{
        public override Type GetSystemType(CMinorEnvironment environment)
        {
            return environment.ResolveTypeAsNormal(GetId());
        }
	}
	
}
