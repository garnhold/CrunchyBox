using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    static public class PitchExtensions_Octave
    {
        static public int GetOctave(this Pitch item)
        {
            return (int)(item.GetSemitones() / Pitch.Octave);
        }

        static public Pitch GetShiftedOctave(this Pitch item, int amount)
        {
            return item.GetShiftedSemitones(amount * Pitch.Octave);
        }
    }
}