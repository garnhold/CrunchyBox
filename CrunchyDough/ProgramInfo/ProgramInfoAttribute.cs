using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class ProgramInfoAttribute : Attribute
    {
        private string name;

        public ProgramInfoAttribute(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }
}