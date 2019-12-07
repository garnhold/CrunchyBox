using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class StringExtensions_ProgrammingEntityName_Event
    {
        static public string GetEntityEventAddMethodName(this string item)
        {
            return "add_" + item;
        }

        static public string GetEntityEventRemoveMethodName(this string item)
        {
            return "remove_" + item;
        }
    }
}