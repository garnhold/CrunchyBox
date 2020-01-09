
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public abstract class CmlScriptEntry : CmlElement
    {
        private CmlScriptRequest request;

        protected CmlScriptRequest InitializeRequest(CmlExecution execution)
        {
            request = new CmlScriptRequest(execution);

            this.GetTopicalChildren<CmlScriptElement>().Process(e => e.Compile(execution, request, request));
            return request;
        }
    }
}
