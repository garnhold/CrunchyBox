using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyKitchen
{
    public class ProjectItemCreator_Extensions_Types<ITEM_TYPE> : ProjectItemCreator_Extensions<ITEM_TYPE>
    {
        private Dictionary<string, Type> types;

        protected override ITEM_TYPE CreateInternal(string name, string extension)
        {
            return types.GetValue(extension).IfNotNull(t => t.CreateInstance<ITEM_TYPE>(name));
        }

        public ProjectItemCreator_Extensions_Types(IEnumerable<KeyValuePair<string, Type>> p)
        {
            types = p.ToDictionary();
        }

        public ProjectItemCreator_Extensions_Types(params KeyValuePair<string, Type>[] p) : this((IEnumerable<KeyValuePair<string, Type>>)p) { }
    }
}