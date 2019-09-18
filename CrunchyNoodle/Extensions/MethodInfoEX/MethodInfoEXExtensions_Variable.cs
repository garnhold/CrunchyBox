using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class MethodInfoEXExtensions_Variable
    {
        static public Variable CreateVariable(this MethodInfoEX item)
        {
            return new Variable_Prop(item.CreatePropInfo());
        }
    }
}