using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_IRegister
    {
        static public IRegister<T> AsRegister<T>(this IList<T> item)
        {
            return new IRegister<T>(item);
        }
    }
}