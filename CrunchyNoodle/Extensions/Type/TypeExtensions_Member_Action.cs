using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_Member_Action
    {
        static public Action GetActionByComponent(this Type item, string component, IEnumerable<object> arguments)
        {
            return item.GetFunctionByComponent(component, arguments.GetTypes())
                .IfNotNull(f => f.CreateAction(arguments));
        }
        static public Action GetActionByComponent(this Type item, string component, params object[] arguments)
        {
            return item.GetActionByComponent(component, (IEnumerable<object>)arguments);
        }

        static public Action GetActionByPathAndComponent(this Type item, string path, string component, IEnumerable<object> arguments)
        {
            return item.GetFunctionByPathAndComponent(path, component, arguments.GetTypes())
                .IfNotNull(f => f.CreateAction(arguments));
        }
        static public Action GetActionByPathAndComponent(this Type item, string path, string component, params object[] arguments)
        {
            return item.GetActionByPathAndComponent(path, component, (IEnumerable<object>)arguments);
        }

        static public Action GetActionByPath(this Type item, string full_path, IEnumerable<object> arguments)
        {
            return item.GetFunctionByPath(full_path, arguments.GetTypes())
                .IfNotNull(f => f.CreateAction(arguments));
        }
        static public Action GetActionByPath(this Type item, string full_path, params object[] arguments)
        {
            return item.GetActionByPath(full_path, (IEnumerable<object>)arguments);
        }
    }
}