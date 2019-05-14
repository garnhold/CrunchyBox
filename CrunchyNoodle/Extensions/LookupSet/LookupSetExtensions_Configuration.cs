using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class LookupSetExtensions_Configuration
    {
        static public bool LoadAsConfigurationInto(this LookupSet<string, string> item, object target, bool strict = false)
        {
            return target.GetFilteredInstanceFields(
                Filterer_FieldInfo.HasCustomAttributeOfType<ConfigurationVariableAttribute>()
            ).ProcessAND(
                f => f.GetCustomAttributeOfType<ConfigurationVariableAttribute>(false).TryHydrateSetting(item, target, f, strict)
            );
        }
    }
}