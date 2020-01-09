using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class ObjectExtensions_MemberInstance_VariableValue
    {
        static public void SetVariableValueByPath(this object item, string path, object value)
        {
            item.GetType().GetVariableByPath(path).SetContents(item, value);
        }

        static public object GetVariableValueByPath(this object item, string path)
        {
            return item.GetType().GetVariableByPath(path).GetContents(item);
        }
        static public T GetVariableValueByPath<T>(this object item, string path)
        {
            return item.GetVariableValueByPath(path).ConvertEX<T>();
        }
    }
}