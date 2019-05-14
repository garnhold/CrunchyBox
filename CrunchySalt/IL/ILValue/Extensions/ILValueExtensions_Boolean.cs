using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILValueExtensions_Boolean
    {
        static public ILValue GetILIsTrue(this ILValue item)
        {
            return item.GetILImplicitCast(typeof(bool));
        }

        static public ILValue GetILIsFalse(this ILValue item)
        {
            return item.GetILImplicitCast(typeof(bool)).GetILLogicalNegated();
        }
    }
}