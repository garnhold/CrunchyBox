using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    static public class SQLiteParameterCollectionExtensions_Set
    {
        static public void Set(this SQLiteParameterCollection item, IEnumerable<SQLiteParameter> to_add)
        {
            item.Clear();
            item.AddRange(to_add);
        }
    }
}