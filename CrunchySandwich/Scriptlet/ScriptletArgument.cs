using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    
    public class ScriptletArgument
    {
        [SerializeFieldEX]private Type type = typeof(int);

        [SerializeFieldEX]private string name = "arg";
        [SerializeFieldEX]private object value = 0;

        public Type GetArgumentType()
        {
            return type;
        }

        public string GetArgumentName()
        {
            return name;
        }

        public object GetArgumentValue()
        {
            return value.ConvertEX(type);
        }
    }
}