using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    static public class SQLiteParameterCollectionExtensions_Set
    {
        static public void Set(this SQLiteParameterCollection item, IEnumerable<SQLiteParameter> to_add)
        {
            item.Clear();
            item.AddRange(to_add);
        }
    }
}