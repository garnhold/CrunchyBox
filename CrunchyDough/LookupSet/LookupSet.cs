using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public interface LookupSet<KEY_TYPE, VALUE_TYPE>
    {
        bool Has(KEY_TYPE key);
        bool TryLookup(KEY_TYPE key, out VALUE_TYPE value);
    }
}