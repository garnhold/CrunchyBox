using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class MethodInfoEXExtensions_Action
    {
        static public Action CreateAction(this MethodInfoEX item, bool convert, IEnumerable<object> arguments)
        {
            return item.CreateFunction().CreateAction(convert, arguments);
        }
        static public Action CreateAction(this MethodInfoEX item, bool convert, params object[] arguments)
        {
            return item.CreateAction(convert, (IEnumerable<object>)arguments);
        }

        static public Action CreateAction(this MethodInfoEX item)
        {
            return item.CreateAction(false);
        }
    }
}