using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class DelegateExtensions_Convert
    {
        static public Delegate ConvertDelegate(this Delegate item, Type type)
        {
            if (item.GetType() == type)
                return item;

            if (item.GetInvocationList().Length == 1)
                return Delegate.CreateDelegate(type, item.Target, item.Method);

            return item.GetInvocationList()
                .Convert(d => d.ConvertDelegate(type))
                .CombineDelegates();
        }
        static public T ConvertDelegate<T>(this Delegate item)
        {
            return item.ConvertDelegate(typeof(T)).Convert<T>();
        }
    }
}