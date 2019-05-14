using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    public class DatabaseConnectionCommissioner_Lazy<T> : DatabaseConnectionCommissioner_Lazy where T : PeriodicProcess
    {
        public DatabaseConnectionCommissioner_Lazy(DatabaseConnectionCreator c, long life_milliseconds) : base(typeof(T), c, life_milliseconds) { }
        public DatabaseConnectionCommissioner_Lazy(DatabaseConnectionCreator c, Duration l) : this(c, l.GetWholeMilliseconds()) { }

        public DatabaseConnectionCommissioner_Lazy(DatabaseConnectionCreator c) : this(c, Duration.Minutes(1.0f)) { }
    }

    public class DatabaseConnectionCommissioner_Lazy : DatabaseConnectionCommissioner
    {
        private object close_lock;
        private PeriodicProcess decommission_process;

        private SQLiteConnection commissioned_connection;

        public DatabaseConnectionCommissioner_Lazy(Type pt, DatabaseConnectionCreator c, long life_milliseconds) : base(c)
        {
            close_lock = new object();
            decommission_process = PeriodicProcess.Create(pt, life_milliseconds, delegate() {
                lock (close_lock)
                {
                    commissioned_connection.Close();
                    commissioned_connection = null;

                    decommission_process.StopClear();
                }
            });
        }

        public override SQLiteConnection CommissionConnection()
        {
            lock (close_lock)
            {
                if (commissioned_connection == null)
                {
                    commissioned_connection = CreateConnection();
                    commissioned_connection.Open();
                }
            }

            decommission_process.StopClear();
            return commissioned_connection;
        }

        public override void DecommissionConnection()
        {
            decommission_process.Restart();
        }
    }
}