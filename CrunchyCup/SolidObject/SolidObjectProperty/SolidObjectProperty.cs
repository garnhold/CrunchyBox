using System;
using System.Reflection;

using System.Data.SQLite;

namespace Crunchy.Cup
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class SolidObjectProperty
    {
        private string name;
        private FieldInfo field;

        public SolidObjectProperty(string n, FieldInfo f)
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