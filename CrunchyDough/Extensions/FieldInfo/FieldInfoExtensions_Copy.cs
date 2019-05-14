using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class FieldInfoExtensions_Copy
    {
        static public void CopyValue(this FieldInfo item, object dst, object src)
        {
            item.SetValue(dst, item.GetValue(src));
        }
    }
}