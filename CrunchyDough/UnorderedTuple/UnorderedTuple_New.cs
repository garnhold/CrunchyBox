using System;

namespace Crunchy.Dough
{
    static public class UnorderedTuple
    {
        static public UnorderedTuple<T1, T2> New<T1, T2>(T1 i1, T2 i2)
        {
            return new UnorderedTuple<T1, T2>(i1, i2);
        }
    }
}