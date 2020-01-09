using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class PropInfoEXExtensions_Variable
    {
        static public Variable CreateVariable(this PropInfoEX item)
        {
            return new Variable_Prop(item);
        }
    }
}