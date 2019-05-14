using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public interface EnumerableLookupSet<KEY_TYPE, VALUE_TYPE> : LookupSet<KEY_TYPE, VALUE_TYPE>, IEnumerable<VALUE_TYPE>
    {
    }
}