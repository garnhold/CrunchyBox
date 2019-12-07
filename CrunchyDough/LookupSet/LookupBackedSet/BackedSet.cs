using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class BackedSet<KEY_TYPE, VALUE_TYPE> : LookupBackedSet<KEY_TYPE, VALUE_TYPE>
    {
        private LookupSet<KEY_TYPE, VALUE_TYPE> main_set;
        private List<LookupSet<KEY_TYPE, VALUE_TYPE>> fallback_sets;

        public BackedSet(LookupSet<KEY_TYPE, VALUE_TYPE> m, IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> f)
        {
            main_set = m;
            fallback_sets = f.ToList();
        }
        public BackedSet(LookupSet<KEY_TYPE, VALUE_TYPE> m, params LookupSet<KEY_TYPE, VALUE_TYPE>[] f) : this(m, (IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>>)f)
        {
        }

        public bool Has(KEY_TYPE key)
        {
            return main_set.Has(key, fallback_sets);
        }

        public bool TryLookup(KEY_TYPE key, out VALUE_TYPE value)
        {
            return main_set.TryLookup(key, out value, fallback_sets);
        }

        public LookupSet<KEY_TYPE, VALUE_TYPE> GetMainSet()
        {
            return main_set;
        }

        public IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> GetFallbackSets()
        {
            return fallback_sets;
        }
    }
}