using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyCane
{
    public class KeylessScale
    {
        private List<double> intervals;
        private List<double> offsets;

        private List<KeylessPitch> pitches;

        public KeylessScale(IEnumerable<double> i)
        {
            intervals = i.ToList();
            offsets = intervals.RunningSum().Prepend(0.0).ToList();

            if (offsets.GetLast() != Pitch.Octave)
                throw new InvalidScaleIntervalsException(i);

            offsets.PopLast();

            pitches = new List<KeylessPitch>();
            for (int octave = 0; octave < 9; octave++)
            {
                pitches.AddRange(
                    offsets.ConvertWithIndex((z, o) => new KeylessPitch(z, octave, this, o + octave * Pitch.Octave))
                );
            }
        }

        public KeylessScale(params double[] intervals) : this((IEnumerable<double>)intervals) { }
        public KeylessScale(string intervals) : this(intervals.Convert(c => (double)c.ParseNumber())) { }

        public KeylessPitch GetPitch(int index)
        {
            return pitches.GetDropped(index);
        }

        public KeylessPitch GetPitch(int index, int octave)
        {
            return GetPitch(index + octave * GetScaleSize());
        }

        public Scale CreateScale(Pitch root)
        {
            return new Scale(root, this);
        }
        public Scale CreateScale(Tone tone)
        {
            return CreateScale(tone.GetPitch(0));
        }

        public KeylessScale CreateMode(int shift)
        {
            return new KeylessScale(intervals.Rotate(shift));
        }

        public int GetScaleSize()
        {
            return offsets.Count;
        }

        public IEnumerable<KeylessPitch> GetPitches()
        {
            return pitches;
        }
    }
}