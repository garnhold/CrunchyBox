﻿using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public class DynamicMethodExtensions_Delegate
    {
        static public T CreateDelegate<T>(this DynamicMethod item)
        {
            return item.CreateDelegate(typeof(T)).Convert<T>();
        }
    }
}