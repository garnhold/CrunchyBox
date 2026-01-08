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
    static public class JArrayExtensions_Get
    {
        static public JToken GetValue(this JArray item, int index)
        {
            return item[index];
        }

        static public JObject GetValueAsJObject(this JArray item, int index)
        {
            return item.GetValue(index)
                .IfNotNull(v => v.AsJObject());
        }

        static public JArray GetValueAsJArray(this JArray item, int index)
        {
            return item.GetValue(index)
                .IfNotNull(v => v.AsJArray());
        }

        static public JValue GetValueAsJValue(this JArray item, int index)
        {
            return item.GetValue(index)
                .IfNotNull(v => v.AsJValue());
        }

        static public object GetValueAs(this JArray item, int index, Type type, object default_value=null)
        {
            return item.GetValue(index)
                .IfNotNull(v => v.ConvertEX(type), default_value);
        }

        static public string GetValueAsString(this JArray item, int index)
        {
            return item.GetValue(index)
                .IfNotNull(v => v.AsString());
        }

        static public int GetValueAsInt(this JArray item, int index)
        {
            return item.GetValue(index)
                .IfNotNull(v => v.AsInt());
        }

        static public bool GetValueAsBool(this JArray item, int index)
        {
            return item.GetValue(index)
                .IfNotNull(v => v.AsBool());
        }
    }
}