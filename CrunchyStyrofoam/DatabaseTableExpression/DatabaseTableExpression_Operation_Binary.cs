using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    public class DatabaseTableExpression_Operation_Binary_Equals : DatabaseTableExpression_Operation_Binary
    {
        public DatabaseTableExpression_Operation_Binary_Equals(DatabaseTableExpression l, DatabaseTableExpression r)
            : base("?LEFT = ?RIGHT", l, r) { }
    }

    public class DatabaseTableExpression_Operation_Binary_NotEquals : DatabaseTableExpression_Operation_Binary
    {
        public DatabaseTableExpression_Operation_Binary_NotEquals(DatabaseTableExpression l, DatabaseTableExpression r)
            : base("?LEFT != ?RIGHT", l, r) { }
    }

    public class DatabaseTableExpression_Operation_Binary_Contains : DatabaseTableExpression_Operation_Binary
    {
        public DatabaseTableExpression_Operation_Binary_Contains(DatabaseTableExpression l, DatabaseTableExpression r)
            : base("?LEFT LIKE '%'||?RIGHT||'%'", l, r) { }
    }

    public class DatabaseTableExpression_Operation_Binary_Add : DatabaseTableExpression_Operation_Binary
    {
        public DatabaseTableExpression_Operation_Binary_Add(DatabaseTableExpression l, DatabaseTableExpression r)
            : base("?LEFT + ?RIGHT", l, r) { }
    }

    public class DatabaseTableExpression_Operation_Binary_Subtract : DatabaseTableExpression_Operation_Binary
    {
        public DatabaseTableExpression_Operation_Binary_Subtract(DatabaseTableExpression l, DatabaseTableExpression r)
            : base("?LEFT - ?RIGHT", l, r) { }
    }

    public class DatabaseTableExpression_Operation_Binary_Multiply : DatabaseTableExpression_Operation_Binary
    {
        public DatabaseTableExpression_Operation_Binary_Multiply(DatabaseTableExpression l, DatabaseTableExpression r)
            : base("?LEFT * ?RIGHT", l, r) { }
    }

    public class DatabaseTableExpression_Operation_Binary_Divide : DatabaseTableExpression_Operation_Binary
    {
        public DatabaseTableExpression_Operation_Binary_Divide(DatabaseTableExpression l, DatabaseTableExpression r)
            : base("?LEFT / ?RIGHT", l, r) { }
    }

    public class DatabaseTableExpression_Operation_Binary_LogicalAnd : DatabaseTableExpression_Operation_Binary
    {
        public DatabaseTableExpression_Operation_Binary_LogicalAnd(DatabaseTableExpression l, DatabaseTableExpression r)
            : base("?LEFT AND ?RIGHT", l, r) { }
    }

    public class DatabaseTableExpression_Operation_Binary_LogicalOr : DatabaseTableExpression_Operation_Binary
    {
        public DatabaseTableExpression_Operation_Binary_LogicalOr(DatabaseTableExpression l, DatabaseTableExpression r)
            : base("?LEFT OR ?RIGHT", l, r) { }
    }

    public abstract class DatabaseTableExpression_Operation_Binary : DatabaseTableExpression_Operation
    {
        private DatabaseTableExpression left;
        private DatabaseTableExpression right;

        protected override string BuildSubExpression(string label, SQLiteParameterCollection parameters)
        {
            switch (label)
            {
                case "LEFT": return left.Build(parameters);
                case "RIGHT": return right.Build(parameters);
            }

            throw new UnaccountedBranchException("label", label);
        }

        public DatabaseTableExpression_Operation_Binary(string lo, DatabaseTableExpression l, DatabaseTableExpression r) : base(lo)
        {
            left = l;
            right = r;
        }
    }
}