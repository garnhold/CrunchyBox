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
        static public JObject GetJObjectByPath(this JObject item, string path)
        {
            JObject obj;

            item.GetValueByPath(path).Convert<JObject>(out obj);
            return obj;
        }

        static public JArray GetJArrayValueByPath(this JObject item, string path)
        {
            JArray array;

            item.GetValueByPath(path).Convert<JArray>(out array);
            return array;
        }

        static public JValue GetJValueValueByPath(this JObject item, string path)
        {
            JValue value;

            item.GetValueByPath(path).Convert<JValue>(out value);
            return value;
        }

        static public object GetNativeValueByPath(this JObject item, string path)
        {
            return item.GetJValueValueByPath(path)
                .IfNotNull(v => v.Value);
        }

        static public string GetStringValueByPath(this JObject item, string path)
        {
            return item.GetNativeValueByPath(path)
                .ToStringEX();
        }

        static public int GetIntValueByPath(this JObject item, string path)
        {
            return item.GetStringValueByPath(path).ParseInt();
        }

        static public bool GetBoolValueByPath(this JObject item, string path)
        {
            return item.GetStringValueByPath(path).ParseBool();
        }
    }
}