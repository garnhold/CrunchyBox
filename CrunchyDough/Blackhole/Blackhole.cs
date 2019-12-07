using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Blackhole
    {
        static public IList<T> IList<T>()
        {
            return BlackholeList<T>.INSTANCE;
        }
    }
}