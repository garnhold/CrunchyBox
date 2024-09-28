using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class FloatExtensions_IEEE754
    {
        static public byte[] GetIEEE754Bytes(this float item)
        {
            return BitConverter.GetBytes(item);
        }
    }
}