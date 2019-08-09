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
    static public class MethtoidExtensions
    {
        static public T Invoke<T>(this Methtoid item)
        {
            return item.Invoke().ConvertEX<T>();
        }
    }
}