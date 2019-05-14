using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_Finger_Get
    {
        static private OperationCache<FingerPrintOperation, Type> GET_FINGER_PRINT_OPERATION = ReflectionCache.Get().NewOperationCache(delegate(Type item) {
            return item.CreateFingerPrintOperation();
        });
        static public FingerPrintOperation GetFingerPrintOperation(this Type item)
        {
            return GET_FINGER_PRINT_OPERATION.Fetch(item);
        }

        static private OperationCache<IsFingerEquivolentOperation, Type> GET_IS_FINGER_EQUIVOLENT_OPERATION = ReflectionCache.Get().NewOperationCache(delegate(Type item) {
            return item.CreateIsFingerEquivolentOperation();
        });
        static public IsFingerEquivolentOperation GetIsFingerEquivolentOperation(this Type item)
        {
            return GET_IS_FINGER_EQUIVOLENT_OPERATION.Fetch(item);
        }
    }
}