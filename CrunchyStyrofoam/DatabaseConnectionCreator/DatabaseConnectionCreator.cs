using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    public abstract class DatabaseConnectionCreator
    {
        public abstract SQLiteConnection CreateConnection();
    }
}