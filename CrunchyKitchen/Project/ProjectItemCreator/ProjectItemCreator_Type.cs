using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Kitchen
{
    using Dough;
    using Noodle;
    
    public class ProjectItemCreator_Type<ITEM_TYPE> : ProjectItemCreator<ITEM_TYPE>
    {
        private Type type;

        public ProjectItemCreator_Type(Type t)
        {
            type = t;
        }

        public override ITEM_TYPE Create(string name)
        {
            return type.CreateInstance<ITEM_TYPE>(name);
        }
    }
}