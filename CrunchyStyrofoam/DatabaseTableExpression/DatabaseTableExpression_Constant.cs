using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    public class DatabaseTableExpression_Constant : DatabaseTableExpression
    {
        private int id;
        private object constant;

        static private int NEXT_CONSTANT_ID = 1;

        public DatabaseTableExpression_Constant(object c)
        {
            id = NEXT_CONSTANT_ID++;
            constant = c;
        }

        public override string Build(SQLiteParameterCollection parameters)
        {
            string parameter_name = "@CONSTANT_" + id;

            parameters.AddWithValue(parameter_name, constant);
            return parameter_name;
        }
    }
}