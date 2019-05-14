using System;

namespace CrunchyBun
{
    public abstract class RandVectorF2Box : RandBox<VectorF2>
    {
        private RandVectorF2Source source;

        public RandVectorF2Box(RandVectorF2Source s)
        {
            source = s;
        }

        public RandVectorF2Box() : this(RandVectorF2.SOURCE) { }

        public RandVectorF2Source GetSource()
        {
            return source;
        }
    }
}