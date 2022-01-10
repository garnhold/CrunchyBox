using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILStatementExtensions_Value
    {
        static public ILValue CreateILChain(this ILStatement item, ILValue value)
        {
            return item.IfNotNull(i => new ILChain(i, value));
        }
    }
}