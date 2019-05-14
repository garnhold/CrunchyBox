﻿using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySodium
{
    static public class TypeExtensions_IL
    {
        static public ILMethodInvokation GetILInvoke(this Type item, string name, IEnumerable<ILValue> arguments)
        {
            return item.GetStaticILMethodInvokation(name, arguments);
        }
        static public ILMethodInvokation GetILInvoke(this Type item, string name, params ILValue[] arguments)
        {
            return item.GetILInvoke(name, (IEnumerable<ILValue>)arguments);
        }
    }
}