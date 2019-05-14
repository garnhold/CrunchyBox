
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
	public abstract partial class CmlScriptStatement : CmlElement, CmlScriptElement
	{
        private ILStatement il_statement;

        protected abstract ILStatement CompileILStatement(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value);

        public void Compile(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            il_statement = CompileILStatement(execution, request, this_value);
        }

        public ILStatement GetILStatement()
        {
            return il_statement;
        }
	}
	
}
