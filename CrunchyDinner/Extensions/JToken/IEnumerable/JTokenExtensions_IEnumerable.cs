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
    static public class JTokenExtensions_IEnumerable
    {
        static public JArray ToJArray(this IEnumerable<JToken> item)
        {
            return new JArray(item);
        }
    }
}