using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class CmlValueSource_InsertParameter : CmlValueSource
    {
        public override CmlValue Solidify(CmlContext context)
        {
            return GetInsertParameter().Solidify(context, true);
        }
    }
	
}
