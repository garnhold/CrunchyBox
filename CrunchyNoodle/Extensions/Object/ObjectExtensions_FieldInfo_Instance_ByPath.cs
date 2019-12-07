using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class ObjectExtensions_FieldInfo_Instance_ByPath
    {
        static public FieldInfo GetInstanceFieldByPath(this object item, string path)
        {
            return item.GetType().GetInstanceFieldByPath(path);
        }
    }
}