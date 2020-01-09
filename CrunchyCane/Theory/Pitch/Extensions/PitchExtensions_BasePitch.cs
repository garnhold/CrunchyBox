using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    static public class PitchExtensions_BasePitch
    {
        static public Pitch GetBasePitch(this Pitch item)
        {
            return new Pitch(item.GetTone());
        }
    }
}