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

        private AutoCompoundState compile_state;
        private Operation<object, object, object[]> compiled_operation;

        public Scriptlet()
        {
            compile_state = AutoCompoundState.New(() => target_type, () => cminor_compile_type, () => code);
        }

        public object Invoke(object target)
        {
            if (compile_state.UpdateState())
            {
                compiled_operation = CMinor.CompileForObjectAndParams(
                    target_type,
                    code,
                    arguments.Convert(a => KeyValuePair.New(a.GetArgumentName(), a.GetArgumentType())),
                    cminor_compile_type
                );
            }

            return compiled_operation(
                target.ConvertEX(target_type),
                arguments.Convert(a => a.GetArgumentValue()).ToArray()
            );
        }
    }
}