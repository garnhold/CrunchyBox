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
    static public class JObjectExtensions_GetByPath
    {
        static public JObject GetValueByPathAsJObject(this JObject item, string path)
        {
            return item.GetValueByPath(path)
                .IfNotNull(v => v.AsJObject());
        }

        static public JArray GetValueByPathAsJArray(this JObject item, string path)
        {
            return item.GetValueByPath(path)
                .IfNotNull(v => v.AsJArray());
        }

        static public JValue GetValueByPathAsJValue(this JObject item, string path)
        {
            return item.GetValueByPath(path)
                .IfNotNull(v => v.AsJValue());
        }

        static public object GetValueByPathAsNative(this JObject item, string path, Type type)
        {
            return item.GetValueByPath(path)
                .IfNotNull(v => v.AsNative(type));
        }

        static public string GetValueByPathAsString(this JObject item, string path)
        {
            return item.GetValueByPath(path)
                .IfNotNull(v => v.AsString());
        }

        static public bool TryGetValueByPathAsInt(this JObject item, string path, out int value)
        {
            int inner_value = 0;
            bool return_value = item.GetValueByPath(path)
                .IfNotNull(v => v.TryAsInt(out inner_value));

            value = inner_value;
            return return_value;
        }
        static public int GetValueByPathAsInt(this JObject item, string path, int default_value)
        {
            return item.GetValueByPath(path)
                .IfNotNull(v => v.AsInt(default_value), default_value);
        }
        static public int GetValueByPathAsInt(this JObject item, string path)
        {
            return item.GetValueByPath(path)
                .IfNotNull(v => v.AsInt());
        }

        static public bool TryGetBoolValueByPath(this JObject item, string path, out bool value)
        {
            bool inner_value = false;
            bool return_value = item.GetValueByPath(path)
                .IfNotNull(v => v.TryAsBool(out inner_value));

            value = inner_value;
            return return_value;
        }
        static public bool GetValueByPathAsBool(this JObject item, string path, bool default_value)
        {
            return item.GetValueByPath(path)
                .IfNotNull(v => v.AsBool(default_value), default_value);
        }
        static public bool GetValueByPathAsBool(this JObject item, string path)
        {
            return item.GetValueByPath(path)
                .IfNotNull(v => v.AsBool());
        }
    }
}