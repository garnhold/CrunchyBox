using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
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