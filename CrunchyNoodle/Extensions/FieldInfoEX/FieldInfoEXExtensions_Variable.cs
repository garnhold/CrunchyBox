using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class FieldInfoEXExtensions_Variable
    {
        static public Variable CreateVariable(this FieldInfoEX item)
        {
            return new Variable_Prop(item.GetProp());
        }
    }
}