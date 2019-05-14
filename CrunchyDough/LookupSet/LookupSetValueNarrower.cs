using System;

namespace CrunchyDough
{
    public class LookupSetValueNarrower<KEY_TYPE, VALUE_TYPE> : LookupSet<KEY_TYPE, VALUE_TYPE>
    {
        private LookupSet<KEY_TYPE, VALUE_TYPE> set;
        private Predicate<VALUE_TYPE> predicate;

        public LookupSetValueNarrower(LookupSet<KEY_TYPE, VALUE_TYPE> s, Predicate<VALUE_TYPE> p)
        {
            set = s;
            predicate = p;
        }

        public bool Has(KEY_TYPE key)
        {
            return set.Has(key);
        }

        public bool TryLookup(KEY_TYPE key, out VALUE_TYPE value)
        {
            if (set.TryLookup(key, out value))
            {
                if (predicate.DoesDescribe(value))
                    return true;
            }

            value = default(VALUE_TYPE);
            return false;
        }
    }
}