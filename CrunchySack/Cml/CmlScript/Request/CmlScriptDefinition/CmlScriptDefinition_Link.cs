
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
    
    public class CmlScriptDefinition_Link : CmlScriptDefinition
    {
        private Type variable_type;

        private string name;

        private Process<object, object, object> set_process;
        private Operation<object, object, object, object> get_operation;

        public CmlScriptDefinition_Link(Type v, string n, Process<object, object, object> s, Operation<object, object, object, object> g)
        {
            variable_type = v;

            name = n;

            set_process = s;
            get_operation = g;
        }

        public VariableInstance CreateVariableInstance(CmlScriptRequest request)
        {
            return new VariableInstance(
                request.GetTargetInfo().GetTarget().GetStrongTarget(), 
                new Variable_Operation(
                    request.GetTargetInfo().GetTargetType(),
                    variable_type, 
                    name,
                    set_process.IfNotNull(p => (TryProcess<object, object>)delegate(object t, object v) {
                        p(
                            request.GetThisArgument().GetArgument(),
                            request.GetHostArgument().GetArgument(),
                            v
                        );

                        return true;
                    }),
                    get_operation.IfNotNull(o => (Operation<object, object>)delegate(object t) {
                        return get_operation(
                            request.GetThisArgument().GetArgument(),
                            request.GetHostArgument().GetArgument(),
                            null
                        );
                    })
                )
            );
        }
    }
}
