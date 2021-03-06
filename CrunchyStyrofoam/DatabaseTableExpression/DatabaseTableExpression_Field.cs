using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    public class DatabaseTableExpression_Field : DatabaseTableExpression
    {
        private DatabaseTableField field;

        public DatabaseTableExpression_Field(DatabaseTableField f)
        {
            field = f;
        }

        public override string Build(SQLiteParameterCollection parameters)
        {
            return field.GetName();
        }
    }
}