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
    static public class TargetedScriptletExtensions
    {
        static public T Invoke<T>(this TargetedScriptlet item)
        {
            return item.Invoke().ConvertEX<T>();
        }
    }
}