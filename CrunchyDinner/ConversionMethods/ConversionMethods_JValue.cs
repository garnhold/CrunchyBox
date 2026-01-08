using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Crunchy.Dough;
using Crunchy.Noodle;

namespace Crunchy.Dinner
{
    [Conversion]
    static public class ConversionMethods_JValue
    {
        [Conversion]
        static public string ToString(JValue item)
        {
            return item.AsString();
        }

        [Conversion]
        static public int ToInt(JValue item)
        {
            return item.AsInt();
        }

        [Conversion]
        static public bool ToBool(JValue item)
        {
            return item.AsBool();
        }
    }
}