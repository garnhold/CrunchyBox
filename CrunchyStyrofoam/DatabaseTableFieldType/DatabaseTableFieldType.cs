using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyStyrofoam
{
    public enum DatabaseTableFieldType
    {
        NULL,
        INTEGER,
        REAL,
        TEXT,
        BLOB
    }
}