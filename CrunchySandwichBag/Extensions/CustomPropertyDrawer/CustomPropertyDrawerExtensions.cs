using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySalt;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class CustomPropertyDrawerExtensions
    {
        static private OperationCache<ValueGetter<Type>> GET_HANDLED_TYPE_GETTER = ReflectionCache.Get().NewOperationCache("GET_HANDLED_TYPE_GETTER", delegate() {
            return typeof(CustomPropertyDrawer)
                .GetFilteredInstanceFieldsOfTypeValueGetters<Type>()
                .GetFirst();
        });
        static public Type GetHandledType(this CustomPropertyDrawer item)
        {
            return GET_HANDLED_TYPE_GETTER.Fetch()(item);
        }

        static private OperationCache<ValueGetter<bool>> DOES_HANDLE_CHILD_TYPES_GETTER = ReflectionCache.Get().NewOperationCache("DOES_HANDLE_CHILD_TYPES_GETTER", delegate() {
            return typeof(CustomPropertyDrawer)
                .GetFilteredInstanceFieldsOfTypeValueGetters<bool>()
                .GetFirst();
        });
        static public bool DoesHandleChildTypes(this CustomPropertyDrawer item)
        {
            return DOES_HANDLE_CHILD_TYPES_GETTER.Fetch()(item);
        }

        static public bool CanHandleType(this CustomPropertyDrawer item, Type type)
        {
            Type handled_type = item.GetHandledType();

            if (handled_type.EqualsEX(type))
                return true;

            if (item.DoesHandleChildTypes())
            {
                if (type.CanBeTreatedAs(handled_type))
                    return true;
            }

            return false;
        }
    }
}