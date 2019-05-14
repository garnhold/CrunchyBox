using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyStyrofoam
{
    static public class DatabaseTableFieldExtensions_Expressions
    {
        static public DatabaseTableExpression EqualsExpression(this DatabaseTableField item, DatabaseTableExpression expression)
        {
            return item.GetExpression().EqualsExpression(expression);
        }

        static public DatabaseTableExpression NotEqualsExpression(this DatabaseTableField item, DatabaseTableExpression expression)
        {
            return item.GetExpression().NotEqualsExpression(expression);
        }

        static public DatabaseTableExpression ContainsExpression(this DatabaseTableField item, DatabaseTableExpression expression)
        {
            return item.GetExpression().ContainsExpression(expression);
        }
    }
}