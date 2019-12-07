using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    public class Database
    {
        private DatabaseConnection connection;
        private List<DatabaseTable> tables;

        static public Database Connect(DatabaseConnection c)
        {
            return new Database(c);
        }

        static public Database Connect(DatabaseConnectionCommissioner c)
        {
            return Connect(new DatabaseConnection(c));
        }

        static public Database ConnectAggressively(DatabaseConnectionCreator c)
        {
            return Connect(new DatabaseConnectionCommissioner_Aggressive(c));
        }

        static public Database ConnectLazily<T>(DatabaseConnectionCreator c) where T : PeriodicProcess
        {
            return Connect(new DatabaseConnectionCommissioner_Lazy<T>(c));
        }

        static public Database ConnectAggressivelyToFile(string filename)
        {
            return ConnectAggressively(new DatabaseConnectionCreator_Filename(filename));
        }

        static public Database ConnectLazilyToFile<T>(string filename) where T : PeriodicProcess
        {
            return ConnectLazily<T>(new DatabaseConnectionCreator_Filename(filename));
        }

        private Database(DatabaseConnection c)
        {
            connection = c;
            tables = new List<DatabaseTable>();
        }

        public DatabaseTable AddTable(DatabaseTable to_add)
        {
            tables.Add(to_add);
            to_add.Initialize(this);

            return to_add;
        }

        public DatabaseConnection GetConnection()
        {
            return connection;
        }
    }
}