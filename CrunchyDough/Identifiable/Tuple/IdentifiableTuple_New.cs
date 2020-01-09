using System;

namespace Crunchy.Dough
{
    static public class IdentifiableTuple
    {
        static public IdentifiableTuple<T1> New<T1>(T1 i1)
            where T1 : Identifiable
        {
            return new IdentifiableTuple<T1>(i1);
        }

        static public IdentifiableTuple<T1, T2> New<T1, T2>(T1 i1, T2 i2)
            where T1 : Identifiable
            where T2 : Identifiable
        {
            return new IdentifiableTuple<T1, T2>(i1, i2);
        }

        static public IdentifiableTuple<T1, T2, T3> New<T1, T2, T3>(T1 i1, T2 i2, T3 i3)
            where T1 : Identifiable
            where T2 : Identifiable
            where T3 : Identifiable
        {
            return new IdentifiableTuple<T1, T2, T3>(i1, i2, i3);
        }

        static public IdentifiableTuple<T1, T2, T3, T4> New<T1, T2, T3, T4>(T1 i1, T2 i2, T3 i3, T4 i4)
            where T1 : Identifiable
            where T2 : Identifiable
            where T3 : Identifiable
            where T4 : Identifiable
        {
            return new IdentifiableTuple<T1, T2, T3, T4>(i1, i2, i3, i4);
        }
    }
}