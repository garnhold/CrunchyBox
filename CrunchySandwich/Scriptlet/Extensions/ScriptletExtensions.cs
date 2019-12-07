using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Ramen;
    
    static public class ScriptletExtensions
    {
        static public T Invoke<T>(this Scriptlet item, object target)
        {
            return item.Invoke(target).ConvertEX<T>();
        }
    }
}