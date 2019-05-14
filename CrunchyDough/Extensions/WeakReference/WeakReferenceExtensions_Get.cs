using System;

namespace CrunchyDough
{
    static public class WeakReferenceExtensions_Get
    {
        static public object Get(this WeakReference item)
        {
            return item.Target;
        }
        static public T Get<T>(this WeakReference item)
        {
            return item.Get().Convert<T>();
        }
        static public bool TryGet<T>(this WeakReference item, out T value)
        {
            return item.Get().Convert<T>(out value);
        }
    }
}