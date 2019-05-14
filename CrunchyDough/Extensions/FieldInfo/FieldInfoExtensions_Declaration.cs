﻿using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class FieldInfoExtensions_Declaration
    {
        static public bool IsDeclaredWithin(this FieldInfo item, Type type)
        {
            if (item.DeclaringType == type)
                return true;

            return false;
        }
    }
}