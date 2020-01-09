using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    public abstract class DatabaseTableExpression_Operation : DatabaseTableExpression
    {
        private string layout;

        protected abstract string BuildSubExpression(string label, SQLiteParameterCollection parameters);

        public DatabaseTableExpression_Operation(string l)
        {
            layout = l;
        }

        public override string Build(SQLiteParameterCollection parameters)
        {
            return layout.RegexReplace("\\?([A-Za-z0-9_]+)", delegate(Match match) {
                return BuildSubExpression(match.Groups[1].Value, parameters);
            }).Surround("(", ")");
        }
    }
}