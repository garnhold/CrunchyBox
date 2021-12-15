using System;

namespace Crunchy.Dough
{
    static public class IntExtensions_AbsorbHash
    {
        static public int AbsorbHash(this int item, int other)
        {
            unchecked
            {
                return item * 23 + other;
            }
        }
        static public int AbsorbObjectHash(this int item, Object other)
        {
            return item.AbsorbHash(other.GetHashCodeEX());
        }
    }
}