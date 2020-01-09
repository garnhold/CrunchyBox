using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    public class ScalePitch
    {
        private KeylessPitch pitch;
        private Scale scale;

        public ScalePitch(KeylessPitch p, Scale s)
        {
            pitch = p;
            scale = s;
        }

        public int GetIndex()
        {
            return pitch.GetIndex();
        }

        public int GetOctave()
        {
            return pitch.GetOctave();
        }

        public Scale GetScale()
        {
            return scale;
        }

        public Pitch GetPitch()
        {
            return pitch.GetPitch(scale.GetRoot());
        }

        public override string ToString()
        {
            return GetPitch().ToString();
        }
    }
}