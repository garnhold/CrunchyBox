using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    using Salt;
    
    public enum DatabaseTableFieldType
    {
        NULL,
        INTEGER,
        REAL,
        TEXT,
        BLOB
    }
}