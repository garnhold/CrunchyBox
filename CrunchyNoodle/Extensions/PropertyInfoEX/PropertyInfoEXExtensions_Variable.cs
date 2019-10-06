using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
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