using System;

namespace Crunchy.Dough
{
    static public class Tuple
    {
        static public Tuple<T1> New<T1>(T1 i1)
        {
            return new Tuple<T1>(i1);
        }

        static public Tuple<T1, T2> New<T1, T2>(T1 i1, T2 i2)
        {
            return new Tuple<T1, T2>(i1, i2);
        }

        static public Tuple<T1, T2, T3> New<T1, T2, T3>(T1 i1, T2 i2, T3 i3)
        {
            return new Tuple<T1, T2, T3>(i1, i2, i3);
        }

        static public Tuple<T1, T2, T3, T4> New<T1, T2, T3, T4>(T1 i1, T2 i2, T3 i3, T4 i4)
        {
            return new Tuple<T1, T2, T3, T4>(i1, i2, i3, i4);
        }

        static public Tuple<T1, T2, T3, T4, T5> New<T1, T2, T3, T4, T5>(T1 i1, T2 i2, T3 i3, T4 i4, T5 i5)
        {
            return new Tuple<T1, T2, T3, T4, T5>(i1, i2, i3, i4, i5);
        }
    }
}