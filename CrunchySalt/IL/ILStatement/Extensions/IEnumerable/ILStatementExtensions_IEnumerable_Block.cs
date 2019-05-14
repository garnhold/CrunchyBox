using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ILStatementExtensions_IEnumerable_Block
    {
        static public ILBlock ToBlock(this IEnumerable<ILStatement> item)
        {
            return new ILBlock(item);
        }
    }
}