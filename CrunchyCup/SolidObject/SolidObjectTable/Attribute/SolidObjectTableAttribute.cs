using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
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