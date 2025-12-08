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
    static public class JArrayExtensions_As
    {
        static public IEnumerable<JObject> AsJObjects(this JArray item)
        {
            return item.Convert<JToken, JObject>();
        }

        static public IEnumerable<JArray> AsJArrays(this JArray item)
        {
            return item.Convert<JToken, JArray>();
        }

        static public IEnumerable<JValue> AsJValues(this JArray item)
        {
            return item.Convert<JToken, JValue>();
        }

        static public IEnumerable<object> AsNatives(this JArray item)
        {
            return item.AsJValues().Convert(v => v.Value);
        }

        static public IEnumerable<object> AsNativesOfType(this JArray item, Type type)
        {
            return item.AsJValues().Convert(v => v.Value.ConvertEX(type));
        }

        static public IEnumerable<string> AsStrings(this JArray item)
        {
            return item.AsNatives().Convert(n => n.ToStringEX());
        }
    }
}