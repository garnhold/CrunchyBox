using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    static public class PitchExtensions_Midi
    {
        static public byte GetMidiNote(this Pitch item)
        {
            return (byte)item.GetSemitones();
        }
    }
}