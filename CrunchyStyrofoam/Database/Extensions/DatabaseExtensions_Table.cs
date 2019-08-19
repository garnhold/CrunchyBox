using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;

namespace CrunchyStyrofoam
{
    static public class DatabaseExtensions_Table
    {
        static public DatabaseTable NewTable(this Database item, string n)
        {
            return item.AddTable(new DatabaseTable(n));
        }
    }
}