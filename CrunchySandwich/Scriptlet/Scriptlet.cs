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

        private Type compiled_target_type;
        private CMinorCompileType compiled_cminor_compile_type;
        private string compiled_code;
        private Operation<object, object, object[]> compiled_operation;

        public object Invoke(object target)
        {
            if (target_type != compiled_target_type || cminor_compile_type != compiled_cminor_compile_type || code != compiled_code)
            {
                compiled_target_type = target_type;
                compiled_cminor_compile_type = cminor_compile_type;
                compiled_code = code;

                compiled_operation = CMinor.CompileForObjectAndParams(
                    compiled_target_type,
                    compiled_code,
                    arguments.Convert(a => KeyValuePair.New(a.GetArgumentName(), a.GetArgumentType())),
                    compiled_cminor_compile_type
                );
            }

            return compiled_operation(
                target.ConvertEX(compiled_target_type),
                arguments.Convert(a => a.GetArgumentValue()).ToArray()
            );
        }
    }
}