using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    static public class PitchExtensions_Semitone
    {
        static public Pitch GetShiftedSemitones(this Pitch item, double amount)
        {
            return new Pitch(item.GetSemitones() + amount);
        }
    }
}