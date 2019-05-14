using System;

namespace CrunchyDough
{
    public struct ValueChangeInfo<T>
    {
        public readonly T old_value;
        public readonly T new_value;

        public ValueChangeInfo(T o, T n)
        {
            old_value = o;
            new_value = n;
        }

        public override bool Equals(object obj)
        {
            ValueChangeInfo<T> cast;

            if (obj.Convert<ValueChangeInfo<T>>(out cast))
            {
                if(cast.old_value.EqualsEX(old_value))
                {
                    if(cast.new_value.EqualsEX(new_value))
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

                hash = hash * 23 + old_value.GetHashCodeEX();
                hash = hash * 23 + new_value.GetHashCodeEX();
                return hash;
            }
        }

        public override string ToString()
        {
            return "(" + old_value + " -> " + new_value + ")";
        }
    }
}