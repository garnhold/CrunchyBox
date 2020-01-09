using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    using Salt;
    
    static public class DatabaseTableFieldTypeExtensions_Type
    {
        static public Type GetSystemType(this DatabaseTableFieldType item)
        {
            switch (item)
            {
                case DatabaseTableFieldType.NULL: return null;
                case DatabaseTableFieldType.INTEGER: return typeof(long);
                case DatabaseTableFieldType.REAL: return typeof(decimal);
                case DatabaseTableFieldType.TEXT: return typeof(string);
                case DatabaseTableFieldType.BLOB: return typeof(byte[]);
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}