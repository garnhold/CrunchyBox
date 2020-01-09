using System;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class IEnumerableBasicExtensions_InspectCount
    {
        static public int InspectCount(this IEnumerable item)
        {
            if (item != null)
            {
                ICollection collection;
                if(item.Convert<ICollection>(out collection))
                    return collection.Count;

                MethodInfo method = item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("get_Count"),
                    Filterer_MethodInfo.CanReturnInto<int>(),
                    Filterer_MethodInfo.HasNoEffectiveParameters()
                ).GetFirst();
                if (method != null)
                    return (int)method.Invoke(item);

                int count = 0;
                foreach (object sub_item in item)
                    count++;

                return count;
            }

            return 0;
        }
    }
}