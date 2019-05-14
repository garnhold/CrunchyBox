using System;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class IEnumerableBasicExtensions_InspectRemoveAt
    {
        static public bool InspectRemoveAt(this IEnumerable item, int index)
        {
            if (item != null)
            {
                MethodInfoEX method = item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("RemoveAt"),
                    Filterer_MethodInfo.HasNoReturn(),
                    Filterer_MethodInfo.CanEffectiveParametersHold<int>()
                ).GetFirst();
                if (method != null)
                {
                    method.Invoke(item, new object[] { index });
                    return true;
                }
            }

            return false;
        }
    }
}