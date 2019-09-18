using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyRamen;

namespace CrunchySandwich
{
    public class Scriptlet
    {
        [SerializeFieldEX]private Type target_type;
        [SerializeFieldEX]private List<ScriptletArgument> arguments;

        [SerializeFieldEX]private CMinorCompileType cminor_compile_type;
        [SerializeFieldEX]private string code;

        private string compile_message;
        private AutoCompoundState compile_state;
        private Operation<object, object, object[]> compiled_operation;

        [InspectorDisplay]
        private string Compile()
        {
            if (compile_state.UpdateState())
            {
                try
                {
                    compiled_operation = CMinor.CompileForObjectAndParams(
                        target_type,
                        code,
                        arguments.Convert(a => KeyValuePair.New(a.GetArgumentName(), a.GetArgumentType())),
                        cminor_compile_type
                    );

                    compile_message = "Success";
                }
                catch (Exception ex)
                {
                    compile_message = ex.Message;

                    Debug.LogException(ex);
                }
            }

            return compile_message;
        }

        public Scriptlet()
        {
            compile_state = AutoCompoundState.New(() => target_type, () => cminor_compile_type, () => code);
        }

        public object Invoke(object target)
        {
            Compile();

            return compiled_operation(
                target.ConvertEX(target_type),
                arguments.Convert(a => a.GetArgumentValue()).ToArray()
            );
        }
    }
}