using System;

namespace Crunchy.Dough
{
    public abstract class RandFloatBox : RandBox<float>
    {
        private RandFloatSource source;

        public RandFloatBox(RandFloatSource s)
        {
            source = s;
        }

        public RandFloatBox() : this(RandFloat.SOURCE) { }

        public RandFloatSource GetSource()
        {
            return source;
        }
    }
}