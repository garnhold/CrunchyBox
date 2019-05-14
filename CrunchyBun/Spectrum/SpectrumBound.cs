using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public class SpectrumBound<T>
    {
        private float value;

        private List<SpectrumBand<T>> starting_bands;
        private List<SpectrumBand<T>> ending_bands;

        private List<SpectrumBand<T>> active_bands;

        public SpectrumBound(float v)
        {
            value = v;

            starting_bands = new List<SpectrumBand<T>>();
            ending_bands = new List<SpectrumBand<T>>();

            active_bands = new List<SpectrumBand<T>>();
        }

        public void AddBandStart(SpectrumBand<T> to_add)
        {
            starting_bands.Add(to_add);
        }

        public void AddBandEnd(SpectrumBand<T> to_add)
        {
            ending_bands.Add(to_add);
        }

        public void RemoveBandStart(SpectrumBand<T> to_remove)
        {
            starting_bands.Remove(to_remove);
        }

        public void RemoveBandEnd(SpectrumBand<T> to_remove)
        {
            ending_bands.Remove(to_remove);
        }

        public void SetActiveBands(IEnumerable<SpectrumBand<T>> b)
        {
            active_bands.Set(b);
        }

        public float GetValue()
        {
            return value;
        }

        public IEnumerable<SpectrumBand<T>> GetStartingBands()
        {
            return starting_bands;
        }

        public IEnumerable<SpectrumBand<T>> GetEndingBands()
        {
            return ending_bands;
        }

        public IEnumerable<SpectrumBand<T>> GetActiveBands()
        {
            return active_bands;
        }
    }
}