using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class MethodInfoEXExtensions_Variable
    {
        static public Variable CreateVariable(this MethodInfoEX item)
        {
            return new Variable_Prop(item.CreatePropInfo());
        }
    }
}