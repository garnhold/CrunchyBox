using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    public class Roulette<T>
    {
        private float total_weight;
        private Spectrum<T> spectrum;

        public Roulette()
        {
            total_weight = 0.0f;
            spectrum = new Spectrum<T>();
        }

        public Roulette(IEnumerable<KeyValuePair<T, float>> i) : this()
        {
            this.Add(i);
        }

        public Roulette(params KeyValuePair<T, float>[] i) : this((IEnumerable<KeyValuePair<T, float>>)i) { }

        public void Clear()
        {
            spectrum.Clear();
        }

        public void Add(T item, float weight)
        {
            float left_spectrum_value = total_weight;
            float right_spectrum_value = left_spectrum_value + weight;

            spectrum.Add(new SpectrumBand<T>(item, left_spectrum_value, right_spectrum_value));
            total_weight = right_spectrum_value;
        }

        public void Remove(T item)
        {
            spectrum.Remove(spectrum.FindFirst(b => b.GetData().EqualsEX(item)));
        }

        public bool TryLookup(float value, out T output)
        {
            SpectrumBand<T> band;

            if (spectrum.Lookup(value).TryGetFirst(out band))
            {
                output = band.GetData();
                return true;
            }

            output = default(T);
            return false;
        }

        public float GetTotalWeight()
        {
            return total_weight;
        }
    }
}