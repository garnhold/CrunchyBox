using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchyRamen;

namespace CrunchySandwich
{
    static public class ScriptletExtensions
    {
        static public T Invoke<T>(this Scriptlet item, object target)
        {
            return item.Invoke(target).ConvertEX<T>();
        }
    }
}