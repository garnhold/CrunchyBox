using System;
using System.Reflection;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
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