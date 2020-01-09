using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    public abstract class DatabaseConnectionCommissioner
    {
        private DatabaseConnectionCreator creator;

        public abstract SQLiteConnection CommissionConnection();
        public abstract void DecommissionConnection();

        protected SQLiteConnection CreateConnection()
        {
            return creator.CreateConnection();
        }

        public DatabaseConnectionCommissioner(DatabaseConnectionCreator c)
        {
            creator = c;
        }
    }
}