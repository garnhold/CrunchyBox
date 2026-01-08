using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Generic
    {
        static public bool TryGetGenericArgument(this Type item, int index, out Type output)
        {
            return item.GetGenericArguments().TryGet(index, out output);
        }

        static public Type GetGenericArgument(this Type item, int index)
        {
            return item.GetGenericArguments().Get(index);
        }

        static public bool FillGenericArgumentsToHold(this Type item, Type to_hold, Type[] generic_arguments)
        {
            if (item.IsGenericParameter)
            {
                generic_arguments.SetDropped(item.GenericParameterPosition, to_hold);

                return true;
            }

            if (item.IsGenericTypelessArray() && to_hold.IsArray())
            {
                if (generic_arguments.Length != 1)
                    throw new SanityCheckException("I assume the number of generic arguments would always be 1 in the case of generic arrays in Type.FillGenericArgumentsToHold.");

                generic_arguments.SetDropped(0, to_hold.GetElementType());
                return true;
            }

            if (item.IsGenericTypelessClass())
            {
                to_hold = to_hold.GetTypeAndAllBaseTypesAndInterfaces(DetailDirection.SpecificToBasic)
                    .Narrow(t => t.IsGenericClass())
                    .FindFirst(t => t.GetGenericTypeDefinition() == item.GetGenericTypeDefinition());

                if (to_hold != null)
                {
                    return item.GetGenericArguments()
                        .PairStrict(to_hold.GetGenericArguments())
                        .AreAll(p => p.item1.FillGenericArgumentsToHold(p.item2, generic_arguments));
                }
            }

            return false;
        }
    }
}