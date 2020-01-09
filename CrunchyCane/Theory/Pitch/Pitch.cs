using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    public struct Pitch
    {
        private double semitones;

        public const double Octave = 12.0;

        public const double Lowest = 0.0;
        public const double Highest = 127.0;

        public Pitch(double s)
        {
            semitones = s.BindBetween(Lowest, Highest);
        }

        public Pitch(int t, int o) : this(t + o * Octave) { }
        public Pitch(Tone t, int o) : this((int)t, o) { }

        public double GetSemitones()
        {
            return semitones;
        }

        public override bool Equals(object obj)
        {
            Pitch cast;

            if (obj.Convert(out cast))
            {
                if (cast.semitones == semitones)
                    return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return semitones.GetHashCode();
        }

        public override string ToString()
        {
            return ((Tone)this.GetTone()).ToString() + this.GetOctave().ToString();
        }
    }
}