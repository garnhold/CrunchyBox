
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
	public partial class CmlScriptEntry_Function : CmlScriptEntry
	{
        private Dictionary<CmlScriptSignature, CmlScriptDefinition_Function> definitions;

        partial void OnConstructor()
        {
            definitions = new Dictionary<CmlScriptSignature, CmlScriptDefinition_Function>();
        }

        public FunctionInstance CompileFunctionInstance(CmlExecution execution)
        {
            CmlScriptRequest request = InitializeRequest(execution);

            CmlScriptDefinition_Function definition = definitions.GetOrCreateValue(request.GetSignature(), delegate() {
                string name = "CmlFunction[" + GetFunctionParameters() + stored_text + "]";

                return new CmlScriptDefinition_Function(
                    name,
                    GetFunctionParameters().IfNotNull(p => p.GetParameterTypes()),
                    
                    GetType().CreateDynamicMethodDelegate<Process<object, object, object>>(
                        name,
                        GetLambda().GetILStatement()
                    )
                );
            });

            return definition.CreateFunctionInstance(request);
        }
	}
	
}
