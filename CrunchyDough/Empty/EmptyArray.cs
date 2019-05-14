using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class EmptyArray<T>
    {
        static public readonly T[] INSTANCE = new T[]{};

        private EmptyArray()
        {
        }
    }
}