using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlEntityCompositeChild : CmlElement, CmlEntityInfo
	{
        public string GetName()
        {
            return RepresentationInfo.UnamedChildren;
        }

        public CmlValue Solidify(CmlContext context)
        {
            return GetComponentSource().GetValue(context);
        }
	}
	
}
