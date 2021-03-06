using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Kitchen
{
    using Dough;
    using Noodle;
    
    public abstract class ProjectItemCreator_Extensions<ITEM_TYPE> : ProjectItemCreator<ITEM_TYPE>
    {
        protected abstract ITEM_TYPE CreateInternal(string name, string extension);

        public override ITEM_TYPE Create(string name)
        {
            return CreateInternal(name, Filename.GetExtension(name).ToLower());
        }
    }
}