using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySalt;

namespace CrunchySodium
{
    static public class ILValueExtensions_Common
    {
        static public ILValue GetILTypeEX(this ILValue item)
        {
            return item.GetILInvoke("GetTypeEX");
        }
    }
}