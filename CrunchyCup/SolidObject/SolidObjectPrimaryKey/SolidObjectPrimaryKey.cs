using System;
using System.Reflection;

using System.Data.SQLite;

namespace Crunchy.Cup
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class SolidObjectPrimaryKey
    {
        private string name;
        private FieldInfo field;

        public SolidObjectPrimaryKey(string n, FieldInfo f)
        {
            name = n;
            field = f;
        }

        public string GetName()
        {
            return name;
        }

        public FieldInfo GetField()
        {
            return field;
        }
    }
}