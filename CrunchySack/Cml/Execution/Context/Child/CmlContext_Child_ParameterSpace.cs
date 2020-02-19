
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
    
    public class CmlContext_Child_ParameterSpace : CmlContext_Child
    {
        private CmlParameterSpace parameter_space;

        public CmlContext_Child_ParameterSpace(CmlContext p, CmlParameterSpace s) : base(p)
        {
            parameter_space = s;
        }

        public override CmlParameterSpace GetParameterSpace()
        {
            return parameter_space;
        }
    }

    static public partial class CmlContextExtensions_NewContext
    {
        static public CmlContext NewParameterSpace(this CmlContext item, IEnumerable<CmlParameter> parameters)
        {
            return new CmlContext_Child_ParameterSpace(item, new CmlParameterSpace(parameters));
        }
    }

}
