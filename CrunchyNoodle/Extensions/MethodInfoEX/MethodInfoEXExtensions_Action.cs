using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
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