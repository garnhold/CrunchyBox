using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    static public class PitchExtensions_Cent
    {
        static public int GetCents(this Pitch item)
        {
            return (int)(item.GetSemitones().GetFractionalComponent() * 100.0);
        }

        static public Pitch GetShiftedCents(this Pitch item, int amount)
        {
            return item.GetShiftedSemitones(amount / 100.0);
        }
    }
}