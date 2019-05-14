using System;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class IEnumerableBasicExtensions_InspectInsert
    {
        static public bool InspectInsert(this IEnumerable item, int index, object value)
        {
            if (item != null)
            {
                MethodInfoEX method = item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Insert"),
                    Filterer_MethodInfo.HasNoReturn(),
                    Filterer_MethodInfo.CanNthEffectiveParameterHold(0, typeof(int)),
                    Filterer_MethodInfo.HasTwoEffectiveParameters()
                ).GetFirst();
                if (method != null)
                {
                    if (value == null)
                        value = method.GetEffectiveParameterType(1).GetDefaultValue();

                    method.Invoke(item, new object[] { index, value });
                    return true;
                }
            }

            return false;
        }

        static public bool InspectInsert(this IEnumerable item, int index)
        {
            return item.InspectInsert(index, null);
        }
    }
}