using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyCane
{
    static public class PitchExtensions_Tone
    {
        static public int GetTone(this Pitch item)
        {
            return (int)(item.GetSemitones() - item.GetOctave() * Pitch.Octave);
        }

        static public Pitch GetShiftedTone(this Pitch item, int amount)
        {
            return item.GetShiftedSemitones(amount);
        }
    }
}