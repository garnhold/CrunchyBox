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
    static public class JObjectExtensions_Get
    {
        static public JObject GetValueAsJObject(this JObject item, string property_name)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsJObject());
        }

        static public JValue GetValueAsJValue(this JObject item, string property_name)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsJValue());
        }

        static public JArray GetValueAsJArray(this JObject item, string property_name)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsJArray());
        }

        static public IEnumerable<string> GetValueAsStrings(this JObject item, string property_name)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsStrings());
        }
        static public IEnumerable<int> GetValueAsInts(this JObject item, string property_name)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsInts());
        }
        static public IEnumerable<bool> GetValueAsBools(this JObject item, string property_name)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsBools());
        }

        static public object GetValueAs(this JObject item, Type type, string property_name, object default_value=null)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.ConvertEX(type), default_value);
        }

        static public string GetValueAsString(this JObject item, string property_name, string default_value=null)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsString(), default_value);
        }

        static public bool TryGetValueAsInt(this JObject item, string property_name, out int value)
        {
            int inner_value = 0;
            bool return_value = item.GetValue(property_name)
                .IfNotNull(v => v.TryAsInt(out inner_value));

            value = inner_value;
            return return_value;
        }
        static public int GetValueAsInt(this JObject item, string property_name, int default_value)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsInt(default_value), default_value);
        }
        static public int GetValueAsInt(this JObject item, string property_name)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsInt());
        }

        static public bool TryGetValueAsBool(this JObject item, string property_name, out bool value)
        {
            bool inner_value = false;
            bool return_value = item.GetValue(property_name)
                .IfNotNull(v => v.TryAsBool(out inner_value));

            value = inner_value;
            return return_value;
        }
        static public bool GetValueAsBool(this JObject item, string property_name, bool default_value)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsBool(default_value), default_value);
        }
        static public bool GetValueAsBool(this JObject item, string property_name)
        {
            return item.GetValue(property_name)
                .IfNotNull(v => v.AsBool());
        }
    }
}