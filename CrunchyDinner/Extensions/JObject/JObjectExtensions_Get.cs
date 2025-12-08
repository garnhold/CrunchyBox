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
        static public JObject GetJObjectValue(this JObject item, string property_name)
        {
            JObject obj;

            item.GetValue(property_name).Convert<JObject>(out obj);
            return obj;
        }

        static public JArray GetJArrayValue(this JObject item, string property_name)
        {
            JArray array;

            item.GetValue(property_name).Convert<JArray>(out array);
            return array;
        }

        static public JValue GetJValueValue(this JObject item, string property_name)
        {
            JValue value;

            item.GetValue(property_name).Convert<JValue>(out value);
            return value;
        }

        static public object GetNativeValue(this JObject item, string property_name, object default_value=null)
        {
            return item.GetJValueValue(property_name)
                .IfNotNull(v => v.Value, default_value);
        }

        static public object GetValueAs(this JObject item, Type type, string property_name, object default_value=null)
        {
            JArray as_array = item.GetJArrayValue(property_name);

            if (as_array != null && type.IsTypicalIEnumerable())
                return as_array.AsNativesOfType(type.GetIEnumerableType()).ConvertEX(type);

            return item.GetNativeValue(property_name, default_value).ConvertEX(type);
        }

        static public string GetStringValue(this JObject item, string property_name)
        {
            return item.GetNativeValue(property_name)
                .ToStringEX();
        }

        static public bool TryGetIntValue(this JObject item, string property_name, out int value)
        {
            return item.GetStringValue(property_name).TryParseInt(out value);
        }
        static public int GetIntValue(this JObject item, string property_name, int default_value)
        {
            return item.GetStringValue(property_name).ParseInt(default_value);
        }
        static public int GetIntValue(this JObject item, string property_name)
        {
            return item.GetStringValue(property_name).ParseInt();
        }

        static public bool TryGetBoolValue(this JObject item, string property_name, out bool value)
        {
            return item.GetStringValue(property_name).TryParseBool(out value);
        }
        static public bool GetBoolValue(this JObject item, string property_name, bool default_value)
        {
            return item.GetStringValue(property_name).ParseBool(default_value);
        }
        static public bool GetBoolValue(this JObject item, string property_name)
        {
            return item.GetStringValue(property_name).ParseBool();
        }
    }
}