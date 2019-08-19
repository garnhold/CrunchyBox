using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyStyrofoam
{
    public class DatabaseTableField_ForeignKey : DatabaseTableField
    {
        private DatabaseTable foreign_table;

        public DatabaseTableField_ForeignKey(string n, DatabaseTable t, DatabaseTableFieldType ft = DatabaseTableFieldType.INTEGER, bool nn = false) : base(n, ft, false, false, nn, false)
        {
            foreign_table = t;
        }

        public override object TransformToInternal(object value)
        {
            DatabaseTableRow row;

            if (value.Convert<DatabaseTableRow>(out row))
                return row.GetPrimaryValue();

            return value;
        }

        public override object TransformFromInternal(object value)
        {
            return foreign_table.RetrieveByPrimaryValue(value);
        }
    }
}