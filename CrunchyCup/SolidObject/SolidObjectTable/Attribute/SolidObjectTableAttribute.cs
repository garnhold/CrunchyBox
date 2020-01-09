using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

namespace Crunchy.Cup
{
    using Dough;
    using Salt;
    using Noodle;
    
    [AttributeUsage(AttributeTargets.Class)]
    public class SolidObjectTableAttribute : Attribute
    {
        private string table_name;

        public SolidObjectTableAttribute(string t)
        {
            table_name = t;
        }

        public string GetTableName()
        {
            return table_name;
        }
    }
}