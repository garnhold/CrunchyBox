using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    static public class DatabaseTableExpressionExtensions_Contains
    {
        static public DatabaseTableExpression ContainsExpression(this DatabaseTableExpression item, DatabaseTableExpression expression)
        {
            return new DatabaseTableExpression_Operation_Binary_Contains(item, expression);
        }
    }
}