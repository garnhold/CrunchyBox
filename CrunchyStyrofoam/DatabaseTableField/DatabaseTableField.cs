using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    using Salt;
    
    public abstract class DatabaseTableField
    {
        private int index;
        private string name;

        private DatabaseTableFieldType field_type;
        private bool is_primary_key;
        private bool is_auto_increment;
        private bool is_not_null;
        private bool is_unique;

        private DatabaseTable table;

        public abstract object TransformToInternal(object value);
        public abstract object TransformFromInternal(object value);

        public DatabaseTableField(string n, DatabaseTableFieldType t, bool pk = false, bool ai = false, bool nn = false, bool u = false)
        {
            name = n.StyleAsEntity();

            field_type = t;
            is_primary_key = pk;
            is_auto_increment = ai;
            is_not_null = nn;
            is_unique = u;
        }

        public void Initialize(DatabaseTable t)
        {
            table = t;
            index = table.GetFields().FindIndexOf(this);
        }

        public SQLiteParameter CreateParameter(object value)
        {
            return new SQLiteParameter(GetParameter(), value);
        }

        public int GetIndex()
        {
            return index;
        }

        public string GetName()
        {
            return name;
        }

        public string GetParameter()
        {
            return "@" + GetName();
        }

        public string GetCreateDeclaration()
        {
            return Enumerable.New(
                GetName(),
                GetFieldType().ToString(),
                IsPrimaryKey().ConvertBool("PRIMARY KEY"),
                IsAutoIncrement().ConvertBool("AUTOINCREMENT"),
                IsNotNull().ConvertBool("NOT NULL"),
                IsUnique().ConvertBool("UNIQUE")
            ).JoinVisible(" ");
        }

        public string GetInsertDeclaration()
        {
            return GetName();
        }

        public string GetInsertValue()
        {
            return GetParameter();
        }

        public string GetUpdateDeclaration()
        {
            return "{0} = {1}".Inject(
                GetName(),
                GetParameter()
            );
        }

        public DatabaseTableFieldType GetFieldType()
        {
            return field_type;
        }

        public Type GetFieldSystemType()
        {
            return GetFieldType().GetSystemType();
        }

        public bool IsPrimaryKey()
        {
            return is_primary_key;
        }

        public bool IsAutoIncrement()
        {
            return is_auto_increment;
        }

        public bool IsNotNull()
        {
            return is_not_null;
        }

        public bool IsUnique()
        {
            return is_unique;
        }

        public DatabaseTable GetTable()
        {
            return table;
        }

        public Database GetDatabase()
        {
            return GetTable().GetDatabase();
        }

        public DatabaseTableExpression GetExpression()
        {
            return new DatabaseTableExpression_Field(this);
        }
    }
}