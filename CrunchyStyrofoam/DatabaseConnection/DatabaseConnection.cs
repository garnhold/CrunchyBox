using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    public class DatabaseConnection
    {
        private SQLiteConnection current_connection;
        private DatabaseConnectionCommissioner connection_commissioner;

        private void UseConnection(Process<SQLiteConnection> process)
        {
            if (current_connection == null)
            {
                current_connection = connection_commissioner.CommissionConnection();

                    process(current_connection);

                connection_commissioner.DecommissionConnection();
                current_connection = null;
            }
            else
            {
                process(current_connection);
            }
        }
        private T UseConnection<T>(Operation<T, SQLiteConnection> operation)
        {
            T temp = default(T);

            UseConnection(delegate(SQLiteConnection connection) {
                temp = operation(connection);
            });

            return temp;
        }

        public DatabaseConnection(DatabaseConnectionCommissioner c)
        {
            connection_commissioner = c;
        }

        public void DoTransaction(Operation<bool> operation)
        {
            UseConnection(delegate(SQLiteConnection connection) {
                SQLiteTransaction transaction = connection.BeginTransaction();

                if (operation())
                    transaction.Commit();
                else
                    transaction.Rollback();
            });
        }
        public void DoTransaction(Process process)
        {
            DoTransaction(delegate() {
                process();

                return true;
            });
        }

        public void DoCommand(Process<SQLiteCommand> process)
        {
            UseConnection(delegate(SQLiteConnection connection) {
                using (SQLiteCommand command = connection.CreateCommand())
                    process(command);
            });
        }
        public T DoCommand<T>(Operation<T, SQLiteCommand> operation)
        {
            T temp = default(T);

            DoCommand(delegate(SQLiteCommand command) {
                temp = operation(command);
            });

            return temp;
        }

        public int DoSimpleNonQuery(string text)
        {
            return DoCommand(delegate(SQLiteCommand command) {
                command.CommandText = text;

                return command.ExecuteNonQuery();
            });
        }
    }
}