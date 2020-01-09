using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    using Salt;
    
    public class DatabaseTableRow
    {
        private Dictionary<DatabaseTableField, object> values;

        private DatabaseTable table;

        public DatabaseTableRow(DatabaseTable t)
        {
            values = new Dictionary<DatabaseTableField, object>();
            table = t;
        }

        public DatabaseTableRow(SQLiteDataReader r, DatabaseTable t) : this(t)
        {
            r.GetValues().Bridge<string>().Process(
                n => values[t.GetField(n)] = r[n]
            );
        }

        public bool Store()
        {
            return GetTable().DoCommand(delegate(SQLiteCommand command) {
                if (HasPrimaryValue())
                {
                    command.Parameters.Set(
                        GetFieldsAndValues().Convert(p => p.Key.CreateParameter(p.Value))
                    );

                    command.CommandText = "INSERT OR IGNORE INTO {0} ({1}) VALUES ({2})".Inject(
                        GetTable().GetName(),
                        GetFieldsAndValues().Convert(p => p.Key.GetInsertDeclaration()).Join(", "),
                        GetFieldsAndValues().Convert(p => p.Key.GetInsertValue()).Join(", ")
                    );
                    if (command.ExecuteNonQuery() == 1)
                        return true;

                    command.CommandText = "UPDATE {0} SET {1} WHERE {2} = {3}".Inject(
                        GetTable().GetName(),
                        GetNonPrimaryFieldsAndValues().Convert(p => p.Key.GetUpdateDeclaration()).Join(", "),
                        GetTable().GetPrimaryField().GetName(),
                        GetTable().GetPrimaryField().GetParameter()
                    );
                    if (command.ExecuteNonQuery() == 1)
                        return true;
                }
                else
                {
                    command.Parameters.Set(
                        GetNonPrimaryFieldsAndValues().Convert(p => p.Key.CreateParameter(p.Value))
                    );

                    command.CommandText = "INSERT INTO {0} ({1}) VALUES ({2})".Inject(
                        GetTable().GetName(),
                        GetNonPrimaryFieldsAndValues().Convert(p => p.Key.GetInsertDeclaration()).Join(", "),
                        GetNonPrimaryFieldsAndValues().Convert(p => p.Key.GetInsertValue()).Join(", ")
                    );
                    if (command.ExecuteNonQuery() == 1)
                        return true;
                }

                return false;
            });
        }

        public void Apply(SQLiteParameterCollection collection)
        {
            collection.AddRange(
                values.Convert(p => p.Key.CreateParameter(p.Value))
            );
        }

        public void SetValue(DatabaseTableField field, object value)
        {
            if (field.GetTable() == table)
                values[field] = field.TransformToInternal(value);
        }

        public void SetPrimaryValue(object value)
        {
            SetValue(table.GetPrimaryField(), value);
        }

        public object GetValue(DatabaseTableField field)
        {
            if (field.GetTable() == table)
                return field.TransformFromInternal(values.GetValue(field));

            return null;
        }
        public T GetValue<T>(DatabaseTableField field)
        {
            return GetValue(field).Convert<T>();
        }

        public object GetPrimaryValue()
        {
            return GetValue(table.GetPrimaryField());
        }

        public bool HasPrimaryValue()
        {
            if (GetPrimaryValue() != null)
                return true;

            return false;
        }

        public KeyValuePair<DatabaseTableField, object> GetPrimaryFieldAndValue()
        {
            return KeyValuePair.New(table.GetPrimaryField(), GetPrimaryValue());
        }

        public IEnumerable<KeyValuePair<DatabaseTableField, object>> GetFieldsAndValues()
        {
            return values;
        }

        public IEnumerable<KeyValuePair<DatabaseTableField, object>> GetNonPrimaryFieldsAndValues()
        {
            return values.Skip(p => p.Key == table.GetPrimaryField());
        }

        public DatabaseTable GetTable()
        {
            return table;
        }

        public Database GetDatabase()
        {
            return GetTable().GetDatabase();
        }

        public DatabaseConnection GetConnection()
        {
            return GetTable().GetConnection();
        }
    }
}