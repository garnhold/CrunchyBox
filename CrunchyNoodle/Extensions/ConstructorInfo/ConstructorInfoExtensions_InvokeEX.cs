using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class ConstructorInfoExtensions_InvokeEX
    {
        static public object InvokeEX(this ConstructorInfo item, object[] arguments)
        {
            return item.InvokeEX(null, arguments);
        }
    }
}