using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    static public class DatabaseTableExtensions_Field
    {
        static public DatabaseTableField NewField(this DatabaseTable item, string n, DatabaseTableFieldType t, bool pk = false, bool ai = false, bool nn = false, bool u = false)
        {
            return item.AddField(new DatabaseTableField(n, t, pk, ai, nn, u));
        }
    }
}