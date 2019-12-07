using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    public abstract class DatabaseTableExpression
    {
        static public DatabaseTableExpression operator +(DatabaseTableExpression l, DatabaseTableExpression r)
        { return new DatabaseTableExpression_Operation_Binary_Add(l, r); }

        static public DatabaseTableExpression operator -(DatabaseTableExpression l, DatabaseTableExpression r)
        { return new DatabaseTableExpression_Operation_Binary_Subtract(l, r); }

        static public DatabaseTableExpression operator *(DatabaseTableExpression l, DatabaseTableExpression r)
        { return new DatabaseTableExpression_Operation_Binary_Multiply(l, r); }

        static public DatabaseTableExpression operator /(DatabaseTableExpression l, DatabaseTableExpression r)
        { return new DatabaseTableExpression_Operation_Binary_Divide(l, r); }

        static public DatabaseTableExpression operator &(DatabaseTableExpression l, DatabaseTableExpression r)
        { return new DatabaseTableExpression_Operation_Binary_LogicalAnd(l, r); }

        static public DatabaseTableExpression operator |(DatabaseTableExpression l, DatabaseTableExpression r)
        { return new DatabaseTableExpression_Operation_Binary_LogicalOr(l, r); }

        static public implicit operator DatabaseTableExpression(DatabaseTableField f) { return f.GetExpression(); }

        static public implicit operator DatabaseTableExpression(byte c) { return new DatabaseTableExpression_Constant(c); }
        static public implicit operator DatabaseTableExpression(short c) { return new DatabaseTableExpression_Constant(c); }
        static public implicit operator DatabaseTableExpression(int c) { return new DatabaseTableExpression_Constant(c); }
        static public implicit operator DatabaseTableExpression(long c) { return new DatabaseTableExpression_Constant(c); }
        static public implicit operator DatabaseTableExpression(float c) { return new DatabaseTableExpression_Constant(c); }
        static public implicit operator DatabaseTableExpression(double c) { return new DatabaseTableExpression_Constant(c); }
        static public implicit operator DatabaseTableExpression(decimal c) { return new DatabaseTableExpression_Constant(c); }
        static public implicit operator DatabaseTableExpression(string c) { return new DatabaseTableExpression_Constant(c); }

        public abstract string Build(SQLiteParameterCollection parameters);

        public string BuildSelect(DatabaseTable table, SQLiteParameterCollection parameters)
        {
            return string.Format("SELECT * FROM {0} WHERE {1}",
                table.GetName(),
                Build(parameters)
            );
        }

        public string BuildCount(DatabaseTable table, SQLiteParameterCollection parameters)
        {
            return string.Format("SELECT COUNT({0}) FROM {1} WHERE {2}",
                table.GetPrimaryField().GetName(),
                table.GetName(),
                Build(parameters)
            );
        }
    }
}