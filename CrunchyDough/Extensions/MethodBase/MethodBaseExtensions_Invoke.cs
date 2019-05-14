using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class MethodBaseExtensions_Invoke
    {
        static public object Invoke(this MethodBase item, object target, params object[] arguments)
        {
            return item.Invoke(target, arguments);
        }
    }
}