using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
    static public class SolidObjectTableAttributeExtensions_Create
    {
        static public SolidObjectTable CreateTable(this SolidObjectTableAttribute item, Type type)
        {
            return new SolidObjectTable(item.GetTableName());
        }
    }
}