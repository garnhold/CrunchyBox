using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    using Salt;
    
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