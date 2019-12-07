
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 10 2018 1:16:26 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class CmlValue_ComponentSourceList : CmlValue
    {
        private CmlComponentSourceList component_source_list;

        public CmlValue_ComponentSourceList(CmlComponentSourceList l)
        {
            component_source_list = l;
        }

        public override CmlScriptValue_Argument CreateScriptArgument()
        {
            throw new CmlRuntimeError_TypeSupportException("passing to script", this);
        }

        public IEnumerable<CmlComponentSource> GetComponentSources()
        {
            return component_source_list.GetComponentSources();
        }
    }

}
