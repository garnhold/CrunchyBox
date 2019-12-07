using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Kitchen
{
    using Dough;
    using Noodle;
    
    public abstract class ProjectItemCreator<ITEM_TYPE>
    {
        public abstract ITEM_TYPE Create(string name);
    }
}