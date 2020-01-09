using System;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class IEnumerableBasicExtensions_InspectRemove
    {
        static public bool InspectRemove(this IEnumerable item, object value)
        {
            if (item != null)
            {
                MethodInfoEX method = item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Remove"),
                    Filterer_MethodInfo.HasOneEffectiveParameter()
                ).GetFirst();
                if (method != null)
                {
                    method.Invoke(item, new object[] { value });
                    return true;
                }
            }

            return false;
        }
    }
}