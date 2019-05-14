using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyStyrofoam
{
    public class DatabaseTable
    {
        private string name;

        private DatabaseTableField primary_field;

        private Dictionary<string, DatabaseTableField> fields;
        private Dictionary<string, DatabaseTableIndex> indexs;

        private bool is_created;

        private Database database;

        private void Validate()
        {
            if (is_created == false)
            {
                GetConnection().DoSimpleNonQuery(string.Format("CREATE TABLE IF NOT EXISTS {0} ({1})",
                    GetName(),
                    GetFields().Convert(z => z.GetCreateDeclaration()).Join(", ")
                ));
                GetIndexs().Process(i => i.CreateIfNotExists());

                is_created = true;
            }
        }

        public DatabaseTable(string n)
        {
            name = n.StyleAsEntity();

            fields = new Dictionary<string, DatabaseTableField>();
            indexs = new Dictionary<string, DatabaseTableIndex>();
        }

        public void Initialize(Database d)
        {
            database = d;
        }

        public void DoCommand(Process<SQLiteCommand> process)
        {
            Validate();

            GetConnection().DoCommand(process);
        }
        public T DoCommand<T>(Operation<T, SQLiteCommand> operation)
        {
            T to_return = default(T);

            DoCommand(delegate(SQLiteCommand command) {
                to_return = operation(command);
            });

            return to_return;
        }

        public int DoSimpleNonQuery(string text)
        {
            return DoCommand(delegate(SQLiteCommand command) {
                command.CommandText = text;

                return command.ExecuteNonQuery();
            });
        }

        public DatabaseTableField AddField(DatabaseTableField to_add)
        {
            fields.Add(to_add.GetName(), to_add);
            to_add.Initialize(this);

            if (to_add.IsPrimaryKey())
                primary_field = to_add;

            return to_add;
        }

        public DatabaseTableIndex AddIndex(DatabaseTableIndex to_add)
        {
            indexs.Add(to_add.GetName(), to_add);
            to_add.Initialize(this);

            if (is_created)
                to_add.CreateIfNotExists();

            return to_add;
        }

        public void Drop()
        {
            GetConnection().DoSimpleNonQuery(string.Format("DROP TABLE IF EXISTS {0}",
                GetName()
            ));
        }

        public void DeleteAll()
        {
            DoSimpleNonQuery(string.Format("DELETE FROM {0}",
                GetName()
            ));  
        }

        public DatabaseTableRow CreateRow()
        {
            return new DatabaseTableRow(this);
        }

        public DatabaseTableRow CreateRow(object primary_value)
        {
            DatabaseTableRow row = CreateRow();

            row.SetPrimaryValue(primary_value);
            return row;
        }

        public IEnumerable<DatabaseTableRow> Retrieve(DatabaseTableExpression expression)
        {
            return DoCommand(delegate(SQLiteCommand command) {
                command.CommandText = expression.BuildSelect(this, command.Parameters);

                List<DatabaseTableRow> rows = new List<DatabaseTableRow>();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        rows.Add(new DatabaseTableRow(reader, this));
                }

                return rows;
            });
        }

        public DatabaseTableRow RetrieveByPrimaryValue(object primary_value)
        {
            return Retrieve(
                GetPrimaryField()
                    .GetExpression()
                    .EqualsExpression(new DatabaseTableExpression_Constant(primary_value))
            ).GetFirst();
        }

        public int Count(DatabaseTableExpression expression)
        {
            return DoCommand(delegate(SQLiteCommand command) {
                command.CommandText = expression.BuildCount(this, command.Parameters);

                return command.ExecuteScalar().Convert<int>();
            });
        }

        public bool HasPrimaryValue(object primary_value)
        {
            if (Count(
                GetPrimaryField()
                    .GetExpression()
                    .EqualsExpression(new DatabaseTableExpression_Constant(primary_value))
            ) >= 1)
            {
                return true;
            }

            return false;
        }

        public DatabaseTableField GetField(string name)
        {
            return fields.GetValue(name);
        }

        public DatabaseTableIndex GetIndex(string name)
        {
            return indexs.GetValue(name);
        }

        public string GetName()
        {
            return name;
        }

        public DatabaseTableField GetPrimaryField()
        {
            return primary_field;
        }

        public IEnumerable<DatabaseTableField> GetFields()
        {
            return fields.Values;
        }

        public IEnumerable<DatabaseTableField> GetNonPrimaryFields()
        {
            return GetFields().Skip(GetPrimaryField());
        }

        public IEnumerable<DatabaseTableIndex> GetIndexs()
        {
            return indexs.Values;
        }

        public Database GetDatabase()
        {
            return database;
        }

        public DatabaseConnection GetConnection()
        {
            return GetDatabase().GetConnection();
        }
    }
}