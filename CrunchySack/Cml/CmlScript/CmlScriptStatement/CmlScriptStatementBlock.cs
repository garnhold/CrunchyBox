
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
    
    public partial class CmlScriptStatementBlock : CmlElement, CmlScriptElement
	{
        private ILBlock il_block;

        public void Compile(CmlExecution execution, CmlScriptRequest request, CmlScriptValue this_value)
        {
            GetStatements().Process(s => s.Compile(execution, request, this_value));

            il_block = new ILBlock(
                GetStatements().Convert(s => s.GetILStatement())
            );
        }

        public ILBlock GetILBlock()
        {
            return il_block;
        }
	}
	
}
