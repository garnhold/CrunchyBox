using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

namespace Crunchy.Cup
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class SolidObjectExtensions_Commit
    {
        static public void Commit(this SolidObject item, SQLiteConnection connection)
        {
            if (item.IsSolidObjectNew())
            {
            }
            else
            {
            }
        }
    }
}