using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    using Salt;
    
    public class DatabaseTableIndex
    {
        private string name;
        private bool is_unique;

        private List<DatabaseTableField> fields;

        private DatabaseTable table;

        public DatabaseTableIndex(string n, bool u, IEnumerable<DatabaseTableField> f)
        {
            name = n.StyleAsEntity();
            is_unique = u;

            fields = f.ToList();
        }

        public DatabaseTableIndex(string n, bool u, params DatabaseTableField[] f) : this(n, u, (IEnumerable<DatabaseTableField>)f) { }

        public DatabaseTableIndex(bool u, IEnumerable<DatabaseTableField> f) : this(f.Convert(z => z.GetName()).Append("index").Join("_"), u, f) { }
        public DatabaseTableIndex(bool u, params DatabaseTableField[] f) : this(u, (IEnumerable<DatabaseTableField>)f) { }

        public void Initialize(DatabaseTable t)
        {
            table = t;
        }

        public void CreateIfNotExists()
        {
            GetConnection().DoSimpleNonQuery(string.Format("CREATE {0} INDEX IF NOT EXISTS {1} ON {2}({3})",
                IsUnique().ConvertBool("UNIQUE"),
                GetName(),
                table.GetName(),
                fields.Convert(f => f.GetName()).Join(", ")
            ));
        }

        public string GetName()
        {
            return name;
        }

        public bool IsUnique()
        {
            return is_unique;
        }

        public DatabaseTable GetTable()
        {
            return table;
        }

        public Database GetDatabase()
        {
            return GetTable().GetDatabase();
        }

        public DatabaseConnection GetConnection()
        {
            return GetDatabase().GetConnection();
        }
    }
}