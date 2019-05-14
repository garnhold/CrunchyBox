using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
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