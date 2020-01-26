using System;

namespace Crunchy.Dough
{
    public abstract class RandVectorI2Box : RandBox<VectorI2>
    {
        private RandVectorI2Source source;

        public RandVectorI2Box(RandVectorI2Source s)
        {
            source = s;
        }

        public RandVectorI2Box() : this(RandVectorI2.SOURCE) { }

        public RandVectorI2Source GetSource()
        {
            return source;
        }
    }
}