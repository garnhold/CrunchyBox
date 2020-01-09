
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
    
    public partial class CmlScriptEntry_Link : CmlScriptEntry
	{
        private Dictionary<CmlScriptSignature, CmlScriptDefinition_Link> definitions;

        partial void OnConstructor()
        {
            definitions = new Dictionary<CmlScriptSignature, CmlScriptDefinition_Link>();
        }

        public VariableInstance CompileVariableInstance(CmlExecution execution)
        {            
            CmlScriptRequest request = InitializeRequest(execution);

            ILValue il_value = GetExpression().GetValue().GetILValue();
            Type expression_type = il_value.GetValueType();

            CmlScriptValue_Argument value_argument = request.AddPrimaryArgument(
                new CmlScriptValue_Argument_Single_Placeholder(expression_type)
            );

            CmlScriptDefinition_Link definition = definitions.GetOrCreateValue(request.GetSignature(), delegate() {
                return new CmlScriptDefinition_Link(
                    expression_type,

                    "CmlLink[" + stored_text + "]",

                    il_value.CanStore().IfTrue(() =>
                        GetType().CreateDynamicMethodDelegate<Process<object, object, object>>(
                            "CmlLink_Store[" + stored_text + "]",
                            new ILAssign(il_value, value_argument.GetILValue())
                        )
                    ),

                    il_value.CanLoad().IfTrue(() =>
                        GetType().CreateDynamicMethodDelegate<Operation<object, object, object, object>>(
                            "CmlLink_Load[" + stored_text + "]",
                            new ILReturn(il_value)
                        )
                    )
                );
            });

            return definition.CreateVariableInstance(request);
        }
	}
	
}
