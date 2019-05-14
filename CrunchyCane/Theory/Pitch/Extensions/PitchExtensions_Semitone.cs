using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyCane
{
    static public class PitchExtensions_Semitone
    {
        static public Pitch GetShiftedSemitones(this Pitch item, double amount)
        {
            return new Pitch(item.GetSemitones() + amount);
        }
    }
}