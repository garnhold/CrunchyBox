using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_MemberInstance_ActionExecute
    {
        static public void ExecuteActionByPath(this object item, string path, params object[] arguments)
        {
            item.GetType().GetActionByPath(path, arguments).Execute(item);
        }
    }
}