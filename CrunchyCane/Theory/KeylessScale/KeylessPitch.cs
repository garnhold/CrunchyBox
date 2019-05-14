using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyCane
{
    public class KeylessPitch
    {
        private int index;
        private int octave;
        private KeylessScale scale;

        private double offset;

        public KeylessPitch(int i, int o, KeylessScale s, double of)
        {
            index = i;
            octave = o;
            scale = s;

            offset = of;
        }

        public int GetIndex()
        {
            return index;
        }

        public int GetOctave()
        {
            return octave;
        }

        public KeylessScale GetScaleType()
        {
            return scale;
        }

        public double GetOffset()
        {
            return offset;
        }

        public Pitch GetPitch(Pitch root)
        {
            return root.GetShiftedSemitones(offset);
        }
    }
}