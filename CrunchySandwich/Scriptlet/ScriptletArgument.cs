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
        [SerializeFieldEX]private Type type;

        [SerializeFieldEX]private string name;
        [SerializeFieldEX]private object value;

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