using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class StringExtensions_ProgrammingEntityName_Property
    {
        static public string GetEntityPropertySetMethodName(this string item)
        {
            return "set_" + item;
        }

        static public string GetEntityPropertyGetMethodName(this string item)
        {
            return "get_" + item;
        }
    }
}