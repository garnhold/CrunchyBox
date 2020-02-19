
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 15 2018 23:37:16 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract partial class CmlEntityChildren : CmlElement, CmlEntityInfo
	{
        public abstract CmlValue GetValue(CmlContext context);

        public string GetName()
        {
            return RepresentationInfo.UnamedChildren;
        }
	}
	
}
