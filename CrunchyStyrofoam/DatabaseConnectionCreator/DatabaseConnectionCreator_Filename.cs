using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    public class DatabaseConnectionCreator_Filename : DatabaseConnectionCreator
    {
        private string filename;

        public DatabaseConnectionCreator_Filename(string f)
        {
            filename = f;
        }

        public override SQLiteConnection CreateConnection()
        {
            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();

            builder.DataSource = Filename.CleanPath(filename);

            return new SQLiteConnection(builder.ToString());
        }
    }
}