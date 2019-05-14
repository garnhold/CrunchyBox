using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public class Spectrum<T> : SpectrumLookup<T>, IEnumerable<SpectrumBand<T>>
    {
        private bool is_ready;

        private float lower_bound;
        private float upper_bound;
        private List<SpectrumBand<T>> bands;
        private SortedList<float, SpectrumBound<T>> bounds;

        private void Ready()
        {
            if (is_ready == false)
            {
                HashSet<SpectrumBand<T>> current_bands = new HashSet<SpectrumBand<T>>();

                lower_bound = float.PositiveInfinity;
                upper_bound = float.NegativeInfinity;

                foreach (SpectrumBound<T> bound in bounds.Values)
                {
                    if (bound.GetValue() < lower_bound)
                        lower_bound = bound.GetValue();

                    if (bound.GetValue() > upper_bound)
                        upper_bound = bound.GetValue();

                    current_bands.AddRange(bound.GetStartingBands());
                    current_bands.RemoveAll(bound.GetEndingBands());

                    bound.SetActiveBands(current_bands);
                }

                is_ready = true;
            }
        }

        public Spectrum()
        {
            is_ready = false;
            bands = new List<SpectrumBand<T>>();
            bounds = new SortedList<float, SpectrumBound<T>>();
        }

        public Spectrum(IEnumerable<SpectrumBand<T>> s) : this()
        {
            this.Add(s);
        }
        public Spectrum(params SpectrumBand<T>[] s) : this((IEnumerable<SpectrumBand<T>>)s) { }

        public Spectrum(IEnumerable<KeyValuePair<float, T>> v) : this(v.ConvertConnections((p, c) => new SpectrumBand<T>(p.Value, p.Key, c.Key))) { }
        public Spectrum(params KeyValuePair<float, T>[] v) : this((IEnumerable<KeyValuePair<float, T>>)v) { }

        public void Clear()
        {
            bands.Clear();
            bounds.Clear();

            is_ready = false;
        }

        public void Add(SpectrumBand<T> band)
        {
            bands.Add(band);

            bounds.GetOrCreateValue(band.GetStart(), v => new SpectrumBound<T>(v)).AddBandStart(band);
            bounds.GetOrCreateValue(band.GetEnd(), v => new SpectrumBound<T>(v)).AddBandEnd(band);

            is_ready = false;
        }

        public void Remove(SpectrumBand<T> band)
        {
            if (bands.Remove(band))
            {
                int start = bounds.IndexOfKey(band.GetStart());
                if (bounds.IsIndexValid(start))
                    bounds.Values[start].RemoveBandStart(band);

                int end = bounds.IndexOfKey(band.GetEnd());
                if (bounds.IsIndexValid(end))
                    bounds.Values[end].RemoveBandEnd(band);

                is_ready = false;
            }
        }

        public IEnumerable<SpectrumBand<T>> Lookup(float value)
        {
            SpectrumBound<T> spectrum_bound;

            Ready();

            if(bounds.TryFindNearestValueByKey(value, out spectrum_bound, BoundType.Below))
                return spectrum_bound.GetActiveBands();

            return Empty.IEnumerable<SpectrumBand<T>>();
        }

        public float GetLowerBound()
        {
            Ready();

            return lower_bound;
        }

        public float GetUpperBound()
        {
            Ready();

            return upper_bound;
        }

        public IEnumerator<SpectrumBand<T>> GetEnumerator()
        {
            return bands.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}