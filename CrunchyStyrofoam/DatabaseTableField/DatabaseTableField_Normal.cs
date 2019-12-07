using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    using Salt;
    
    public class DatabaseTableField_Normal : DatabaseTableField
    {
        public DatabaseTableField_Normal(string n, DatabaseTableFieldType t, bool nn = false, bool u = false) : base(n, t, false, false, nn, u)
        {
        }

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