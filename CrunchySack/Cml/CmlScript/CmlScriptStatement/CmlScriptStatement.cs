
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
    
    public abstract partial class CmlScriptStatement : CmlElement, CmlScriptElement
	{
        private ILStatement il_statement;

        protected abstract ILStatement CompileILStatement(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value);

        public void Compile(CmlContext context, CmlScriptRequest request, CmlScriptValue this_value)
        {
            il_statement = CompileILStatement(context, request, this_value);
        }

        public ILStatement GetILStatement()
        {
            return il_statement;
        }
	}
	
}
