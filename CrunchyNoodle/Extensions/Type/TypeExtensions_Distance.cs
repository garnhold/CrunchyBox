using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class TypeExtensions_Distance
    {
        static private OperationCache<int, Type, Type> GET_TYPE_DISTANCE_TO_CHILD = ReflectionCache.Get().NewOperationCache("GET_TYPE_DISTANCE_TO_CHILD", delegate(Type parent, Type child) {
            int distance = 0;

            if (parent.IsInterface)
            {
                while (child != parent)
                {
                    Type new_child;

                    if (child.GetImmediateInterfaces().TryFindFirst(t => t.CanBeTreatedAs(parent), out new_child))
                        child = new_child;
                    else
                        child = child.BaseType;

                    distance++;
                }
            }
            else
            {
                while (child != parent)
                {
                    child = child.BaseType;
                    distance++;
                }
            }

            return distance;
        });
        static public int GetTypeDistanceToChild(this Type item, Type child)
        {
            return GET_TYPE_DISTANCE_TO_CHILD.Fetch(item, child);
        }

        static public int GetTypeDistanceToParent(this Type item, Type parent)
        {
            return parent.GetTypeDistanceToChild(item);
        }
        
        static public int GetTypeDistance(this Type item, Type target)
        {
            if (item.IsParentOf(target))
                return item.GetTypeDistanceToChild(target);

            return item.GetTypeDistanceToParent(target);
        }
    }
}