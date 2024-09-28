using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class DoubleExtensions_IEEE754
    {
        static public byte[] GetIEEE754Bytes(this double item)
        {
            return BitConverter.GetBytes(item);
        }
    }
}