using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    static public class DatabaseTableExtensions_Index_Index
    {
        static public DatabaseTableIndex NewIndex(this DatabaseTable item, string n, IEnumerable<DatabaseTableField> f)
        {
            return item.NewIndex(n, false, f);
        }
        static public DatabaseTableIndex NewIndex(this DatabaseTable item, string n, params DatabaseTableField[] f)
        {
            return item.NewIndex(n, (IEnumerable<DatabaseTableField>)f);
        }

        static public DatabaseTableIndex NewIndex(this DatabaseTable item, IEnumerable<DatabaseTableField> f)
        {
            return item.NewIndex(false, f);
        }
        static public DatabaseTableIndex NewIndex(this DatabaseTable item, params DatabaseTableField[] f)
        {
            return item.NewIndex((IEnumerable<DatabaseTableField>)f);
        }
    }
}