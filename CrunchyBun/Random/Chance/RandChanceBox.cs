using System;

namespace Crunchy.Bun
{
    public class RandChanceBox : RandBox<bool>
    {
        private float chance;
        private RandChanceSource source;

        public RandChanceBox(float c, RandChanceSource s)
        {
            chance = c;
            source = s;
        }

        public RandChanceBox(float c) : this(c, RandChance.SOURCE) { }

        public override bool Get()
        {
            return source.Get(chance);
        }

        public RandChanceSource GetSource()
        {
            return source;
        }
    }
}