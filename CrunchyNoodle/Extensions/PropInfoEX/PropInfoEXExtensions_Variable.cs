using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class PropInfoEXExtensions_Variable
    {
        static public Variable CreateVariable(this PropInfoEX item)
        {
            return new Variable_Prop(item);
        }
    }
}