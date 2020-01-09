using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class MethodInfoEXExtensions_Action
    {
        static public Action CreateAction(this MethodInfoEX item, IEnumerable<object> arguments)
        {
            return item.CreateFunction().CreateAction(arguments);
        }
        static public Action CreateAction(this MethodInfoEX item, params object[] arguments)
        {
            return item.CreateAction((IEnumerable<object>)arguments);
        }
    }
}