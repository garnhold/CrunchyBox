using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    static public class SQLiteParameterCollectionExtensions_Add
    {
        static public void AddRange(this SQLiteParameterCollection item, IEnumerable<SQLiteParameter> to_add)
        {
            to_add.Process(p => item.Add(p));
        }
    }
}