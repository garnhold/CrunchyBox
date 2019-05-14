using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyStyrofoam
{
    static public class DatabaseTableRowExtensions_Stream
    {
        static public Stream GetReadStream(this DatabaseTableRow item, DatabaseTableField field)
        {
            return new DatabaseTableRowStream(item, field, true, false);
        }

        static public Stream GetWriteStream(this DatabaseTableRow item, DatabaseTableField field)
        {
            return new DatabaseTableRowStream(item, field, false, true);
        }
    }
}