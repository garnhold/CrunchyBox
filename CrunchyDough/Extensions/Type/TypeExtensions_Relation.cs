using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_Relation
    {
        static public bool IsSpecializationOf(this Type item, Type type)
        {
            if (item != type)
            {
                if (type.IsAssignableFrom(item))
                    return true;
            }

            return false;
        }
        static public bool IsSpecializationOf<T>(this Type item)
        {
            return item.IsSpecializationOf(typeof(T));
        }

        static public bool IsChildOf(this Type item, Type type)
        {
            if (item.IsSubclassOf(type))
                return true;

            return false;
        }
        static public bool IsChildOf<T>(this Type item)
        {
            return item.IsChildOf(typeof(T));
        }

        static public bool IsGeneralizationOf(this Type item, Type type)
        {
            if (type.IsSpecializationOf(item))
                return true;

            return false;
        }
        static public bool IsGeneralizationOf<T>(this Type item)
        {
            return item.IsGeneralizationOf(typeof(T));
        }

        static public bool IsParentOf(this Type item, Type type)
        {
            if (type.IsSubclassOf(item))
                return true;

            return false;
        }
        static public bool IsParentOf<T>(this Type item)
        {
            return item.IsParentOf(typeof(T));
        }

        static public bool IsRelated(this Type item, Type type)
        {
            if (item != null && type != null)
            {
                if (item.IsVoidType() == false && type.IsVoidType() == false)
                {
                    if (item.IsAssignableFrom(type) || type.IsAssignableFrom(item))
                        return true;
                }
            }

            return false;
        }
    }
}