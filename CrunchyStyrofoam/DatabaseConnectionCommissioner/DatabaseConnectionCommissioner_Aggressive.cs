using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    public class DatabaseConnectionCommissioner_Aggressive : DatabaseConnectionCommissioner
    {
        private SQLiteConnection connection;

        public DatabaseConnectionCommissioner_Aggressive(DatabaseConnectionCreator c) : base(c)
        {
        }

        public override SQLiteConnection CommissionConnection()
        {
            connection = CreateConnection();

            connection.Open();
            return connection;
        }

        public override void DecommissionConnection()
        {
            connection.Close();
            connection = null;
        }
    }
}