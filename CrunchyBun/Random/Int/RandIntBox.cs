using System;

namespace Crunchy.Bun
{
    public abstract class RandIntBox : RandBox<int>
    {
        private RandIntSource source;

        public RandIntBox(RandIntSource s)
        {
            source = s;
        }

        public RandIntBox() : this(RandInt.SOURCE) { }

        public RandIntSource GetSource()
        {
            return source;
        }
    }
}