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
    static public class JTokenExtensions_As
    {
        static public JValue AsJValue(this JToken item)
        {
            item.Convert<JValue>(out JValue value);
            return value;
        }
        static public JObject AsJObject(this JToken item)
        {
            item.Convert<JObject>(out JObject @object);
            return @object;
        }
        static public JArray AsJArray(this JToken item)
        {
            item.Convert<JArray>(out JArray array);
            return array;
        }

        static public IEnumerable<string> AsStrings(this JToken item)
        {
            return item.AsJArray().IfNotNull(a => a.AsStrings());
        }
        static public IEnumerable<int> AsInts(this JToken item)
        {
            return item.AsJArray().IfNotNull(a => a.AsInts());
        }
        static public IEnumerable<bool> AsBools(this JToken item)
        {
            return item.AsJArray().IfNotNull(a => a.AsBools());
        }

        static public string AsString(this JToken item)
        {
            return item.AsJValue().IfNotNull(v => v.Value.ToStringEX());
        }

        static public bool TryAsInt(this JToken item, out int value)
        {
            return item.AsString().TryParseInt(out value);
        }
        static public int AsInt(this JToken item, int default_value)
        {
            return item.AsString().ParseInt(default_value);
        }
        static public int AsInt(this JToken item)
        {
            return item.AsString().ParseInt();
        }

        static public bool TryAsBool(this JToken item, out bool value)
        {
            return item.AsString().TryParseBool(out value);
        }
        static public bool AsBool(this JToken item, bool default_value)
        {
            return item.AsString().ParseBool(default_value);
        }
        static public bool AsBool(this JToken item)
        {
            return item.AsString().ParseBool();
        }
    }
}