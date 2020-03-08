using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class MethodBaseExtensions_Invoke
    {
        //TODO: What here???
        static public object Invoke(this MethodBase item, object target, params object[] arguments)
        {
            return item.Invoke(target, arguments);
        }
    }
}