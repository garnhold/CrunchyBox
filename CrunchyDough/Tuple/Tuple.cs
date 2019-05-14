using System;

namespace CrunchyDough
{
    public struct Tuple<T1, T2, T3, T4, T5>
    {
        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;
        public readonly T4 item4;
        public readonly T5 item5;

        static public bool operator ==(Tuple<T1, T2, T3, T4, T5> t1, Tuple<T1, T2, T3, T4, T5> t2)
        {
            return t1.EqualsEX(t2);
        }
        static public bool operator !=(Tuple<T1, T2, T3, T4, T5> t1, Tuple<T1, T2, T3, T4, T5> t2)
        {
            return t1.NotEqualsEX(t2);
        }

        public Tuple(T1 i1, T2 i2, T3 i3, T4 i4, T5 i5)
        {
            item1 = i1;
            item2 = i2;
            item3 = i3;
            item4 = i4;
            item5 = i5;
        }

        public override bool Equals(object obj)
        {
            Tuple<T1, T2, T3, T4, T5> cast;

            if (obj.Convert<Tuple<T1, T2, T3, T4, T5>>(out cast))
            {
                if (cast.item1.EqualsEX(item1))
                {
                    if (cast.item2.EqualsEX(item2))
                    {
                        if (cast.item3.EqualsEX(item3))
                        {
                            if (cast.item4.EqualsEX(item4))
                            {
                                if (cast.item5.EqualsEX(item5))
                                    return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + item1.GetHashCodeEX();
                hash = hash * 23 + item2.GetHashCodeEX();
                hash = hash * 23 + item3.GetHashCodeEX();
                hash = hash * 23 + item4.GetHashCodeEX();
                hash = hash * 23 + item5.GetHashCodeEX();
                return hash;
            }
        }

        public override string ToString()
        {
            return "(" + item1.ToStringEX() + ", " + item2.ToStringEX() + ", " + item3.ToStringEX() + ", " + item4.ToStringEX() + ", " + item5.ToStringEX() + ")";
        }
    }

    public struct Tuple<T1, T2, T3, T4>
    {
        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;
        public readonly T4 item4;

        static public bool operator ==(Tuple<T1, T2, T3, T4> t1, Tuple<T1, T2, T3, T4> t2)
        {
            return t1.EqualsEX(t2);
        }
        static public bool operator !=(Tuple<T1, T2, T3, T4> t1, Tuple<T1, T2, T3, T4> t2)
        {
            return t1.NotEqualsEX(t2);
        }

        public Tuple(T1 i1, T2 i2, T3 i3, T4 i4)
        {
            item1 = i1;
            item2 = i2;
            item3 = i3;
            item4 = i4;
        }

        public override bool Equals(object obj)
        {
            Tuple<T1, T2, T3, T4> cast;

            if (obj.Convert<Tuple<T1, T2, T3, T4>>(out cast))
            {
                if (cast.item1.EqualsEX(item1))
                {
                    if (cast.item2.EqualsEX(item2))
                    {
                        if (cast.item3.EqualsEX(item3))
                        {
                            if (cast.item4.EqualsEX(item4))
                                return true;
                        }
                    }
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + item1.GetHashCodeEX();
                hash = hash * 23 + item2.GetHashCodeEX();
                hash = hash * 23 + item3.GetHashCodeEX();
                hash = hash * 23 + item4.GetHashCodeEX();
                return hash;
            }
        }

        public override string ToString()
        {
            return "(" + item1.ToStringEX() + ", " + item2.ToStringEX() + ", " + item3.ToStringEX() + ", " + item4.ToStringEX() + ")";
        }
    }

    public struct Tuple<T1, T2, T3>
    {
        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;

        static public bool operator ==(Tuple<T1, T2, T3> t1, Tuple<T1, T2, T3> t2)
        {
            return t1.EqualsEX(t2);
        }
        static public bool operator !=(Tuple<T1, T2, T3> t1, Tuple<T1, T2, T3> t2)
        {
            return t1.NotEqualsEX(t2);
        }

        public Tuple(T1 i1, T2 i2, T3 i3)
        {
            item1 = i1;
            item2 = i2;
            item3 = i3;
        }

        public override bool Equals(object obj)
        {
            Tuple<T1, T2, T3> cast;

            if (obj.Convert<Tuple<T1, T2, T3>>(out cast))
            {
                if (cast.item1.EqualsEX(item1))
                {
                    if (cast.item2.EqualsEX(item2))
                    {
                        if (cast.item3.EqualsEX(item3))
                            return true;
                    }
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + item1.GetHashCodeEX();
                hash = hash * 23 + item2.GetHashCodeEX();
                hash = hash * 23 + item3.GetHashCodeEX();
                return hash;
            }
        }

        public override string ToString()
        {
            return "(" + item1.ToStringEX() + ", " + item2.ToStringEX() + ", " + item3.ToStringEX() + ")";
        }
    }

    public struct Tuple<T1, T2>
    {
        public readonly T1 item1;
        public readonly T2 item2;

        static public bool operator ==(Tuple<T1, T2> t1, Tuple<T1, T2> t2)
        {
            return t1.EqualsEX(t2);
        }
        static public bool operator !=(Tuple<T1, T2> t1, Tuple<T1, T2> t2)
        {
            return t1.NotEqualsEX(t2);
        }

        public Tuple(T1 i1, T2 i2)
        {
            item1 = i1;
            item2 = i2;
        }

        public override bool Equals(object obj)
        {
            Tuple<T1, T2> cast;

            if (obj.Convert<Tuple<T1, T2>>(out cast))
            {
                if (cast.item1.EqualsEX(item1))
                {
                    if (cast.item2.EqualsEX(item2))
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

                hash = hash * 23 + item1.GetHashCodeEX();
                hash = hash * 23 + item2.GetHashCodeEX();
                return hash;
            }
        }

        public override string ToString()
        {
            return "(" + item1.ToStringEX() + ", " + item2.ToStringEX() + ")";
        }
    }

    public struct Tuple<T1>
    {
        public readonly T1 item1;

        static public bool operator ==(Tuple<T1> t1, Tuple<T1> t2)
        {
            return t1.EqualsEX(t2);
        }
        static public bool operator !=(Tuple<T1> t1, Tuple<T1> t2)
        {
            return t1.NotEqualsEX(t2);
        }

        public Tuple(T1 i1)
        {
            item1 = i1;
        }

        public override bool Equals(object obj)
        {
            Tuple<T1> cast;

            if (obj.Convert<Tuple<T1>>(out cast))
            {
                if (cast.item1.EqualsEX(item1))
                {
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

                hash = hash * 23 + item1.GetHashCodeEX();
                return hash;
            }
        }

        public override string ToString()
        {
            return "(" + item1.ToStringEX() + ")";
        }
    }
}