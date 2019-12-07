using System;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class IEnumerableBasicExtensions_InspectSet
    {
        static public bool InspectSet(this IEnumerable item, int index, object value)
        {
            if (item != null)
            {
                IList list;
                if (item.Convert<IList>(out list))
                {
                    list[index] = value;
                    return true;
                }

                MethodInfo method = item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("set_Item"),
                    Filterer_MethodInfo.CanNthEffectiveParameterHold(0, typeof(int)),
                    Filterer_MethodInfo.HasTwoEffectiveParameters()
                ).GetFirst();
                if (method != null)
                {
                    method.Invoke(item, new object[] { index, value });
                    return true;
                }
            }

            return false;
        }
    }
}