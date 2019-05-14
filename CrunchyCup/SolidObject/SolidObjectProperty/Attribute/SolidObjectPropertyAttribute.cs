using System;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
    [AttributeUsage(AttributeTargets.Field)]
    public class SolidObjectPropertyAttribute : Attribute
    {
    }
}