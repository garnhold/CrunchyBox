using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class SkewWaveTypeExtensions
    {
        static public float Calculate(this SkewWaveType item, float x, float skew)
        {
            return Wave.Skew(item, x, skew);
        }
    }
}