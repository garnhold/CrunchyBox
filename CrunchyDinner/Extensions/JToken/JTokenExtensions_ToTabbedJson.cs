using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Crunchy.Dough;

namespace Crunchy.Dinner
{
    static public class JTokenExtensions_ToTabbedJson
    {
        static public string ToTabbedJson(this JToken item)
        {
            using (StringWriter string_writer = new StringWriter())
            using (JsonTextWriter json_writer = new JsonTextWriter(string_writer))
            {
                json_writer.IndentChar = '\t';
                json_writer.Indentation = 1;
                json_writer.Formatting = Formatting.Indented;

                item.WriteTo(json_writer);
                return string_writer.ToString();
            }
        }
    }
}