using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    static public class DatabaseTableExtensions_Store
    {
        static public void BatchStore(this DatabaseTable item, IEnumerable<DatabaseTableRow> to_store)
        {
            item.GetConnection().DoTransaction(delegate() {
                to_store.Process(r => r.Store());
            });
        }

        static public void BatchStore(this DatabaseTable item, IEnumerable<DatabaseTableRow> to_store, int batch_size)
        {
            to_store
                .ChunkPermissive(batch_size)
                .Process(b => item.BatchStore(b));
        }
    }
}