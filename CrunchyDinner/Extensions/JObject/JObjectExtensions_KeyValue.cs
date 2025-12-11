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
    static public class JObjectExtensions_KeyValue
    {
        static public IEnumerable<KeyValuePair<string, JToken>> GetKeyValuePairs(this JObject item)
        {
            return item.Properties().Convert(p => KeyValuePair.New(p.Name, p.Value));
        }
    }
}