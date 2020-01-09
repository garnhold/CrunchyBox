using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    static public class DatabaseTableExtensions_Index
    {
        static public DatabaseTableIndex NewIndex(this DatabaseTable item, string n, bool u, IEnumerable<DatabaseTableField> f)
        {
            return item.AddIndex(new DatabaseTableIndex(n, u, f));
        }
        static public DatabaseTableIndex NewIndex(this DatabaseTable item, string n, bool u, params DatabaseTableField[] f)
        {
            return item.NewIndex(n, u, (IEnumerable<DatabaseTableField>)f);
        }

        static public DatabaseTableIndex NewIndex(this DatabaseTable item, bool u, IEnumerable<DatabaseTableField> f)
        {
            return item.AddIndex(new DatabaseTableIndex(u, f));
        }
        static public DatabaseTableIndex NewIndex(this DatabaseTable item, bool u, params DatabaseTableField[] f)
        {
            return item.NewIndex(u, (IEnumerable<DatabaseTableField>)f);
        }
    }
}