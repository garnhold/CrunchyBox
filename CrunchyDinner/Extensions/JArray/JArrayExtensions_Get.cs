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
    static public class JArrayExtensions_Get
    {
        static public JToken GetValue(this JArray item, int index)
        {
            return item[index];
        }

        static public JObject GetJObjectValue(this JArray item, int index)
        {
            JObject obj;

            item.GetValue(index).Convert<JObject>(out obj);
            return obj;
        }

        static public JArray GetJArrayValue(this JArray item, int index)
        {
            JArray array;

            item.GetValue(index).Convert<JArray>(out array);
            return array;
        }

        static public JValue GetJValueValue(this JArray item, int index)
        {
            JValue value;

            item.GetValue(index).Convert<JValue>(out value);
            return value;
        }

        static public object GetNativeValue(this JArray item, int index)
        {
            return item.GetJValueValue(index)
                .IfNotNull(v => v.Value);
        }

        static public string GetStringValue(this JArray item, int index)
        {
            return item.GetNativeValue(index)
                .ToStringEX();
        }
    }
}