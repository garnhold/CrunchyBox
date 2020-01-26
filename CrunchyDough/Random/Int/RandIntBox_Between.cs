using System;

namespace Crunchy.Dough
{
    public class RandIntBox_Between : RandIntBox
    {
        private int a;
        private int b;

        public RandIntBox_Between(int na, int nb, RandIntSource s) : base(s)
        {
            a = na;
            b = nb;
        }

        public RandIntBox_Between(int na, int nb) : this(na, nb, RandInt.SOURCE) { }

        public override int Get()
        {
            return GetSource().GetBetween(a, b);
        }
    }
}