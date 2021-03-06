using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
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