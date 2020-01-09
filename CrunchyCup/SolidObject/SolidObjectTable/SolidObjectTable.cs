using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

namespace Crunchy.Cup
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class SolidObjectTable
    {
        private string table_name;

        public SolidObjectTable(string n)
        {
            table_name = n;
        }

        public string GetTableName()
        {
            return table_name;
        }
    }
}