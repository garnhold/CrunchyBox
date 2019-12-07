using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class RelatableExtensions_Children_Internal
    {
        static public IEnumerable<object> GetImmediateChildren(object item)
        {
            return item.RetrieveMarkedInstanceValues<object, RelatableChildAttribute>();
        }

        static public IEnumerable<object> GetChildren(object item, Predicate<object> predicate)
        {
            foreach (object child in GetImmediateChildren(item))
            {
                yield return child;

                if (predicate.DoesDescribe(child))
                {
                    foreach (object sub_child in GetChildren(child, predicate))
                        yield return sub_child;
                }
            }
        }

        static public IEnumerable<object> GetSelfAndChildren(object item, Predicate<object> predicate)
        {
            yield return item;

            if (predicate.DoesDescribe(item))
            {
                foreach (object child in GetChildren(item, predicate))
                    yield return child;
            }
        }
    }
}