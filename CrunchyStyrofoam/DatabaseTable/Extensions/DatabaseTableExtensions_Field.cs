using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    static public class DatabaseTableExtensions_Field
    {
        static public DatabaseTableField NewFieldNormal(this DatabaseTable item, string n, DatabaseTableFieldType t, bool nn = false, bool u = false)
        {
            return item.AddField(new DatabaseTableField_Normal(n, t, nn, u));
        }

        static public DatabaseTableField NewFieldForeignKey(this DatabaseTable item, string n, DatabaseTable t, DatabaseTableFieldType ft = DatabaseTableFieldType.INTEGER, bool nn = false)
        {
            return item.AddField(new DatabaseTableField_ForeignKey(n, t, ft, nn));
        }

        static public DatabaseTableField NewFieldPrimaryKey(this DatabaseTable item, DatabaseTableFieldType t = DatabaseTableFieldType.INTEGER, bool ai = true)
        {
            return item.AddField(new DatabaseTableField_PrimaryKey(t, ai));
        }
    }
}