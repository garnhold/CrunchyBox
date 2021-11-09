using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class BasicWaveTypeExtensions
    {
        static public float Calculate(this BasicWaveType item, float x)
        {
            return Wave.Basic(item, x);
        }
    }
}