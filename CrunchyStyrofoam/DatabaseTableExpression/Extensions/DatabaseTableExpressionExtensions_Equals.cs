using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    static public class DatabaseTableExpressionExtensions_Equals
    {
        static public DatabaseTableExpression EqualsExpression(this DatabaseTableExpression item, DatabaseTableExpression expression)
        {
            return new DatabaseTableExpression_Operation_Binary_Equals(item, expression);
        }
    }
}