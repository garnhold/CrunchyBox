using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    
    static public class DatabaseExtensions_Table
    {
        static public DatabaseTable NewTable(this Database item, string n)
        {
            return item.AddTable(new DatabaseTable(n));
        }
    }
}