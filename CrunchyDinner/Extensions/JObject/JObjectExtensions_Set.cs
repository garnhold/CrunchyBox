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
        static public void SetValueAsJObject(this JObject item, string property_name, JObject value)
        {
            item.Add(property_name, value);
        }

        static public void SetValueAsJArray(this JObject item, string property_name, JArray value)
        {
            item.Add(property_name, value);
        }

        static public void SetValueAsJValue(this JObject item, string property_name, JValue value)
        {
            item.Add(property_name, value);
        }

        static public void SetValueAsString(this JObject item, string property_name, string value)
        {
            item.SetValueAsJValue(property_name, new JValue(value));
        }

        static public void SetValueAsInt(this JObject item, string property_name, int value)
        {
            item.SetValueAsJValue(property_name, new JValue(value));
        }

        static public void SetValueAsBool(this JObject item, string property_name, bool value)
        {
            item.SetValueAsJValue(property_name, new JValue(value));
        }
    }
}