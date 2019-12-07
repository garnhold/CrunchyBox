
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: June 29 2019 15:40:47 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cheese
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    
    [MExpFunction]
    static public class MExpFunctions
    {
        [MExpFunction]
        static public float wave_sine(float x)
        {
            return Wave.Sine(x);
        }

        [MExpFunction]
        static public float wave_saw(float x)
        {
            return Wave.Saw(x);
        }

        [MExpFunction]
        static public float wave_reverse_saw(float x)
        {
            return Wave.ReverseSaw(x);
        }

        [MExpFunction]
        static public float wave_square(float x)
        {
            return Wave.Square(x);
        }

        [MExpFunction]
        static public float wave_pulse(float x, float duty)
        {
            return Wave.Pulse(x, duty);
        }
    }
	
}
