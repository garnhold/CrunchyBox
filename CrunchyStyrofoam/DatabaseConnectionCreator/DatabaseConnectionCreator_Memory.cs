using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    public class DatabaseConnectionCreator_Memory : DatabaseConnectionCreator
    {
        public override SQLiteConnection CreateConnection()
        {
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();

            builder.DataSource = ":memory:";

            return new SQLiteConnection(builder.ToString());
        }
    }
}