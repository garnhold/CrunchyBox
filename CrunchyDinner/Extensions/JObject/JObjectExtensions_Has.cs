using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Crunchy.Dough;

namespace Crunchy.Dinner
{
    static public class JObjectExtensions_Has
    {
        static public bool HasValue(this JObject item, string property_name)
        {
            if (item.GetValue(property_name) != null)
                return true;

            return false;
        }
    }
}