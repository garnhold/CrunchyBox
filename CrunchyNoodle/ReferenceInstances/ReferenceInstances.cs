using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class ReferenceInstances<T>
    {
        static private OperationCache<List<Type>> GET_ALL_TYPES = ReflectionCache.Get().NewOperationCache("GET_ALL_TYPES", delegate() {
            return Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<T>(),
                Filterer_Type.IsConcreteClass()
            )
            .ToList();
        });
        static public IEnumerable<Type> GetAllTypes()
        {
            return GET_ALL_TYPES.Fetch();
        }

        static private OperationCache<List<T>> GET_ALL = ReflectionCache.Get().NewOperationCache("GET_ALL", delegate() {
            return GetAllTypes()
                .CreateInstances<T>()
                .ToList();
        });
        static public IEnumerable<T> GetAll()
        {
            return GET_ALL.Fetch();
        }

        static public T FindFirst(Predicate<T> predicate)
        {
            return GetAll().FindFirst(predicate);
        }
    }
}