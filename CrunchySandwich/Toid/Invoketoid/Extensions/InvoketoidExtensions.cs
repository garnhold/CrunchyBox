using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class InvoketoidExtensions
    {
        static public T Invoke<T>(this Invoketoid item, GameObject target)
        {
            return item.Invoke(target).ConvertEX<T>();
        }
    }
}