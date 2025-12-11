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
    static public class JPropertyExtensions_IEnumerable
    {
        static public JObject ToJObject(this IEnumerable<JProperty> item)
        {
            return new JObject(item);
        }
    }
}