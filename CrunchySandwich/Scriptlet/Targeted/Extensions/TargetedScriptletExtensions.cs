using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;    using Ramen;
    
    static public class TargetedScriptletExtensions
    {
        static public T Invoke<T>(this TargetedScriptlet item)
        {
            return item.Invoke().ConvertEX<T>();
        }
    }
}