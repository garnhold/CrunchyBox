using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    static public class DatabaseTableExtensions_Index_Unique
    {
        static public DatabaseTableIndex NewUniqueIndex(this DatabaseTable item, string n, IEnumerable<DatabaseTableField> f)
        {
            return item.NewIndex(n, true, f);
        }
        static public DatabaseTableIndex NewUniqueIndex(this DatabaseTable item, string n, params DatabaseTableField[] f)
        {
            return item.NewUniqueIndex(n, (IEnumerable<DatabaseTableField>)f);
        }

        static public DatabaseTableIndex NewUniqueIndex(this DatabaseTable item, IEnumerable<DatabaseTableField> f)
        {
            return item.NewIndex(true, f);
        }
        static public DatabaseTableIndex NewUniqueIndex(this DatabaseTable item, params DatabaseTableField[] f)
        {
            return item.NewUniqueIndex((IEnumerable<DatabaseTableField>)f);
        }
    }
}