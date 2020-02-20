using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlEntityMountPoint : CmlElement, CmlEntityInfo
    {
        public string GetName()
        {
            return RepresentationInfo.UnamedChildren;
        }

        public CmlValue Solidify(CmlContext context)
        {
            return context.GetParameterSpace()
                .IfNotNull(s => s.GetParameter(RepresentationInfo.UnamedChildren))
                .IfNotNull(p => p.Solidify());
        }
    }
    
}
