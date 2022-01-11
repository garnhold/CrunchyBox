using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class ILValueExtensions_Common
    {
        static public ILValue GetILTypeEX(this ILValue item)
        {
            return item.GetILInvoke("GetTypeEX");
        }
    }
}