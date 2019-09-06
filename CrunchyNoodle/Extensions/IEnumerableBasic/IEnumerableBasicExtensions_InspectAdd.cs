using System;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class IEnumerableBasicExtensions_InspectAdd
    {
        static public bool InspectAdd(this IEnumerable item, object value)
        {
            if (item != null)
            {
                MethodInfoEX method = item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Add"),
                    Filterer_MethodInfo.HasOneEffectiveParameter()
                ).GetFirst();
                if (method != null)
                {
                    if (value == null)
                        value = method.GetEffectiveParameterType(0).GetDefaultValue();

                    method.Invoke(item, new object[] { value });
                    return true;
                }

                return item.InspectInsert(
                    item.InspectCount(),
                    value
                );
            }

            return false;
        }
    }
}