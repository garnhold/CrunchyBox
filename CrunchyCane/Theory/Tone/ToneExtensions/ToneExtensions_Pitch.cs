using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    static public class ToneExtensions_Pitch
    {
        static public Pitch GetPitch(this Tone item, int octave)
        {
            return new Pitch(item, octave);
        }
    }
}