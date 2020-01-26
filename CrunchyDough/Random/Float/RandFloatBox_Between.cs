using System;

namespace Crunchy.Dough
{
    public class RandFloatBox_Between : RandFloatBox
    {
        private float a;
        private float b;

        public RandFloatBox_Between(float na, float nb, RandFloatSource s) : base(s)
        {
            a = na;
            b = nb;
        }

        public RandFloatBox_Between(float na, float nb) : this(na, nb, RandFloat.SOURCE) { }

        public override float Get()
        {
            return GetSource().GetBetween(a, b);
        }
    }
}