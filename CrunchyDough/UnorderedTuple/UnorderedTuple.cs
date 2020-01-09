using System;

namespace Crunchy.Dough
{
    public struct UnorderedTuple<T1, T2>
    {
        public readonly T1 item1;
        public readonly T2 item2;

        static public bool operator ==(UnorderedTuple<T1, T2> t1, UnorderedTuple<T1, T2> t2)
        {
            return t1.EqualsEX(t2);
        }
        static public bool operator !=(UnorderedTuple<T1, T2> t1, UnorderedTuple<T1, T2> t2)
        {
            return t1.NotEqualsEX(t2);
        }

        public UnorderedTuple(T1 i1, T2 i2)
        {
            item1 = i1;
            item2 = i2;
        }

        public override bool Equals(object obj)
        {
            UnorderedTuple<T1, T2> cast;

            if (obj.Convert<UnorderedTuple<T1, T2>>(out cast))
            {
                if (cast.item1.EqualsEX(item1))
                {
                    if (cast.item2.EqualsEX(item2))
                        return true;
                }
                else if (cast.item1.EqualsEX(item2))
                {
                    if (cast.item2.EqualsEX(item1))
                        return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                int lower;
                int upper;

                item1.GetHashCodeEX().Order(item2.GetHashCodeEX(), out lower, out upper);

                hash = hash * 23 + lower;
                hash = hash * 23 + upper;
                return hash;
            }
        }

        public override string ToString()
        {
            return "(" + item1.ToStringEX() + ", " + item2.ToStringEX() + ")";
        }
    }
}