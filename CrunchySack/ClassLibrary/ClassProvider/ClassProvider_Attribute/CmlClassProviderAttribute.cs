using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class CmlClassProviderAttribute : Attribute
    {
        private string layout;
        private string cml;

        public CmlClassProviderAttribute(string l, string c)
        {
            layout = l;
            cml = c;
        }

        public string GetLayout()
        {
            return layout;
        }

        public string GetCml()
        {
            return cml;
        }

        public CmlEntry_Class_ClassDefinition GetCmlClass(Type t)
        {
            return new CmlEntry_Class_ClassDefinition(t, layout, CmlClassDefinition.DOMify(cml));
        }
    }
}