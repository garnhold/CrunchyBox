using System;

using CrunchyDough;

namespace CrunchyBun
{
    public class RandChanceSource
    {
        private RandFloatSource source;

        public RandChanceSource(RandFloatSource s)
        {
            source = s;
        }

        public bool Get(float chance)
        {
            if (source.Get() < chance)
                return true;

            return false;
        }
    }
}