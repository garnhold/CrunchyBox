using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public interface LookupBackedSet<KEY_TYPE, VALUE_TYPE> : LookupSet<KEY_TYPE, VALUE_TYPE>
    {
        LookupSet<KEY_TYPE, VALUE_TYPE> GetMainSet();
        IEnumerable<LookupSet<KEY_TYPE, VALUE_TYPE>> GetFallbackSets();
    }
}