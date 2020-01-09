using System;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class IEnumerableBasicExtensions_InspectGet
    {
        static public object InspectGet(this IEnumerable item, int index)
        {
            if (item != null)
            {
                IList list;
                if (item.Convert<IList>(out list))
                    return list[index];

                MethodInfo method = item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("get_Item"),
                    Filterer_MethodInfo.CanReturnInto<object>(),
                    Filterer_MethodInfo.CanEffectiveParametersHold<int>()
                ).GetFirst();
                if (method != null)
                    return method.Invoke(item, new object[] { index });

                int count = 0;
                foreach (object sub_item in item)
                {
                    if (count == index)
                        return sub_item;

                    count++;
                }
            }

            return null;
        }
    }
}