using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    public class DatabaseConnectionCommissioner_Permanent : DatabaseConnectionCommissioner
    {
        private SQLiteConnection connection;

        public DatabaseConnectionCommissioner_Permanent(DatabaseConnectionCreator c) : base(c)
        {
        }

        public override SQLiteConnection CommissionConnection()
        {
            if (connection == null)
            {
                connection = CreateConnection();
                connection.Open();
            }

            return connection;
        }

        public override void DecommissionConnection()
        {
        }
    }
}