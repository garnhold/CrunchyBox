using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public class RouletteWheel<T>
    {
        private Roulette<T> roulette;
        private RandFloatSource float_source;

        public RouletteWheel(RandFloatSource s, Roulette<T> r)
        {
            roulette = r;
            float_source = s;
        }

        public RouletteWheel(RandFloatSource s, IEnumerable<KeyValuePair<T, float>> i) : this(s, new Roulette<T>(i)) { }
        public RouletteWheel(RandFloatSource s, params KeyValuePair<T, float>[] i) : this(s, (IEnumerable<KeyValuePair<T, float>>)i) { }

        public RouletteWheel(IEnumerable<KeyValuePair<T, float>> i) : this(RandFloat.SOURCE, i) { }
        public RouletteWheel(params KeyValuePair<T, float>[] i) : this(RandFloat.SOURCE, i) { }

        public T Spin()
        {
            return roulette.Lookup(float_source.GetMagnitude(roulette.GetTotalWeight()));
        }

        public Roulette<T> GetRoulette()
        {
            return roulette;
        }
    }
}