using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

namespace Crunchy.Cup
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class SolidObjectTableAttributeExtensions_Create
    {
        static public SolidObjectTable CreateTable(this SolidObjectTableAttribute item, Type type)
        {
            return new SolidObjectTable(item.GetTableName());
        }
    }
}