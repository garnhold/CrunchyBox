using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class Swap
    {
        static public void Values<T>(ref T value1, ref T value2)
        {
            T temp = value1;

            value1 = value2;
            value2 = temp;
        }
    }
}