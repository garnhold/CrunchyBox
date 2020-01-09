using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILValueExtensions_Null
    {
        static public ILValue GetILIsNull(this ILValue item)
        {
            return item.GetILEqualTo(ILNull.INSTANCE);
        }

        static public ILValue GetILIsNotNull(this ILValue item)
        {
            return item.GetILNotEqualTo(ILNull.INSTANCE);
        }
    }
}