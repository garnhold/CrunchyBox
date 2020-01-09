using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ILStatementExtensions_IEnumerable_Block
    {
        static public ILBlock ToBlock(this IEnumerable<ILStatement> item)
        {
            return new ILBlock(item);
        }
    }
}