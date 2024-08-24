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
    static public class JObjectExtensions_Set
    {
        static public void SetJObjectValue(this JObject item, string property_name, JObject value)
        {
            item.Add(property_name, value);
        }

        static public void SetJArrayValue(this JObject item, string property_name, JArray value)
        {
            item.Add(property_name, value);
        }

        static public void SetJValueValue(this JObject item, string property_name, JValue value)
        {
            item.Add(property_name, value);
        }

        static public void SetNativeValue(this JObject item, string property_name, object value)
        {
            item.SetJValueValue(property_name, new JValue(value));
        }

        static public void SetStringValue(this JObject item, string property_name, string value)
        {
            item.SetNativeValue(property_name, value);
        }

        static public void SetIntValue(this JObject item, string property_name, int value)
        {
            item.SetNativeValue(property_name, value);
        }

        static public void SetBoolValue(this JObject item, string property_name, bool value)
        {
            item.SetNativeValue(property_name, value);
        }
    }
}