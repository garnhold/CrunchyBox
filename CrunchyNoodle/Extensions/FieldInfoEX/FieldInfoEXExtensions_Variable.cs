using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class FieldInfoEXExtensions_Variable
    {
        static public Variable CreateVariable(this FieldInfoEX item)
        {
            return new Variable_Prop(item.GetProp());
        }
    }
}