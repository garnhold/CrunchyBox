using System;

using System.Data.SQLite;

namespace Crunchy.Cup
{
    using Dough;
    using Salt;
    using Noodle;
    
    [AttributeUsage(AttributeTargets.Field)]
    public class SolidObjectPropertyAttribute : Attribute
    {
    }
}