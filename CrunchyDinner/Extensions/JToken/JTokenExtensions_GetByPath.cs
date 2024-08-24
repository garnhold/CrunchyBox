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
    static public class JTokenExtensions_GetByPath
    {
        static public JToken GetValueByPath(this JToken item, string path)
        {
            return item.SelectToken(path);
        }
    }
}