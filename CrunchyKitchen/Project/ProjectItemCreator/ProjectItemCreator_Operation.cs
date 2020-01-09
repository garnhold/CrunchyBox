using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Kitchen
{
    using Dough;
    using Noodle;
    
    public class ProjectItemCreator_Operation<ITEM_TYPE> : ProjectItemCreator<ITEM_TYPE>
    {
        private Operation<ITEM_TYPE, string> operation;

        public ProjectItemCreator_Operation(Operation<ITEM_TYPE, string> o)
        {
            operation = o;
        }

        public override ITEM_TYPE Create(string name)
        {
            return operation(name);
        }
    }
}