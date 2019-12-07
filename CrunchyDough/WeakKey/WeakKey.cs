using System;

namespace Crunchy.Dough
{
    public class WeakKey<T> : WeakReference<T> where T : class
    {
        private int referenced_hash_code;

        static public T Dereference(object obj)
        {
            WeakKey<T> cast;

            if (obj.Convert<WeakKey<T>>(out cast))
            {
                if (cast.IsAlive())
                    return cast.Get();
            }

            return obj.Convert<T>();
        }

        static public int DereferenceHashCode(object obj)
        {
            WeakKey<T> cast;

            if (obj.Convert<WeakKey<T>>(out cast))
            {
                if (cast.IsAlive())
                    return cast.Get().GetHashCodeEX();

                return cast.GetReferencedHashCode();
            }

            return obj.GetHashCodeEX();
        }

        static public bool DereferenceEquals(object left, object right)
        {
            if (ReferenceEquals(Dereference(left), Dereference(right)))
                return true;

            return false;
        }

        static public bool DereferenceIsNull(object obj)
        {
            if (Dereference(obj).IsNull())
                return true;

            return false;
        }

        public WeakKey(T obj) : base(obj)
        {
            referenced_hash_code = obj.GetHashCodeEX();
        }

        public int GetReferencedHashCode()
        {
            return referenced_hash_code;
        }
    }
}