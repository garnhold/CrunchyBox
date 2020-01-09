using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class PropertyInfoEXExtensions_Variable
    {
        static public Variable CreateVariable(this PropertyInfoEX item)
        {
            return item.GetProp().CreateVariable();
        }

        static public Variable CreatePermissiveVariable(this PropertyInfoEX item)
        {
            return item.GetPermissiveProp().CreateVariable();
        }
    }
}