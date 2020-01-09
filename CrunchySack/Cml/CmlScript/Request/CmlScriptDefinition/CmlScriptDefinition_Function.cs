
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
    
    public class CmlScriptDefinition_Function : CmlScriptDefinition
    {
        private string name;

        private List<Type> parameter_types;
        private Process<object, object, object> process;

        public CmlScriptDefinition_Function(string n, IEnumerable<Type> ps, Process<object, object, object> p)
        {
            name = n;

            parameter_types = ps.ToList();
            process = p;
        }

        public FunctionInstance CreateFunctionInstance(CmlScriptRequest request)
        {
            return new FunctionInstance(
                request.GetTargetInfo().GetTarget().GetStrongTarget(),
                new Function_Operation(
                    request.GetTargetInfo().GetTargetType(),
                    typeof(void),
                    name,
                    parameter_types,
                    delegate(object t, object[] p) {
                        process(
                            request.GetThisArgument().GetArgument(),
                            request.GetHostArgument().GetArgument(),
                            p
                        );

                        return null;
                    }
                )
            );
        }
    }
}
