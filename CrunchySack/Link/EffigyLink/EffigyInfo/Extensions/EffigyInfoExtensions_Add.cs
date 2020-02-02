using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class EffigyInfoExtensions_Add
    {
        static public object AddGetChild(this EffigyInfo item, object representation, object to_add)
        {
            item.AddChild(representation, to_add);

            return to_add;
        }
    }
}