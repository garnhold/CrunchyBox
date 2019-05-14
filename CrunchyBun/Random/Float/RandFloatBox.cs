using System;

namespace CrunchyBun
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