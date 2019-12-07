using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    public class Scale
    {
        private Pitch root;
        private KeylessScale scale_type;

        private List<ScalePitch> pitches;

        public Scale(Pitch r, KeylessScale s)
        {
            root = r.GetBasePitch();
            scale_type = s;

            pitches = scale_type.GetPitches()
                .Convert(p => new ScalePitch(p, this))
                .ToList();
        }

        public ScalePitch GetPitch(int index)
        {
            return pitches.GetDropped(index);
        }

        public ScalePitch GetPitch(int index, int octave)
        {
            return GetPitch(index + octave * GetScaleSize());
        }

        public Pitch GetRoot()
        {
            return root;
        }

        public int GetScaleSize()
        {
            return scale_type.GetScaleSize();
        }

        public IEnumerable<ScalePitch> GetPitches()
        {
            return pitches;
        }
    }
}