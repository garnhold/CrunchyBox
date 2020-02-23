
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 13 2018 18:20:51 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlContext_Child_UnitSpace : CmlContext_Child
    {
        private CmlUnitSpace unit_space;

        public CmlContext_Child_UnitSpace(CmlContext p, CmlUnitSpace s) : base(p)
        {
            unit_space = s;
        }

        public override CmlUnitSpace GetUnitSpace()
        {
            return unit_space;
        }
    }

    static public partial class CmlContextExtensions_NewContext
    {
        static public CmlContext NewUnitSpace(this CmlContext item)
        {
            return new CmlContext_Child_UnitSpace(item, new CmlUnitSpace());
        }
    }

}
