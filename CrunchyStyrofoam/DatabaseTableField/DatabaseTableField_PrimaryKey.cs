using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyStyrofoam
{
    public class DatabaseTableField_PrimaryKey : DatabaseTableField
    {
        public DatabaseTableField_PrimaryKey(DatabaseTableFieldType t = DatabaseTableFieldType.INTEGER, bool ai = true) : base("id", t, true, ai, false, true) { }

        public override object TransformToInternal(object value)
        {
            return value;
        }

        public override object TransformFromInternal(object value)
        {
            return value;
        }
    }
}