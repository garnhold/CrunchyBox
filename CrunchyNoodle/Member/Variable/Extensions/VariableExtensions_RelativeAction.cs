using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class VariableExtensions_RelativeAction
    {
        static public Action GetRelativeActionByComponent(this Variable item, string component, IEnumerable<object> arguments)
        {
            return item.GetRelativeFunctionByComponent(component, arguments.GetTypes())
                .IfNotNull(f => f.CreateAction(arguments));
        }
        static public Action GetRelativeActionByComponent(this Variable item, string component, params object[] arguments)
        {
            return item.GetRelativeActionByComponent(component, (IEnumerable<object>)arguments);
        }

        static public Action GetRelativeActionByPathAndComponent(this Variable item, string path, string component, IEnumerable<object> arguments)
        {
            return item.GetRelativeFunctionByPathAndComponent(path, component, arguments.GetTypes())
                .IfNotNull(f => f.CreateAction(arguments));
        }
        static public Action GetRelativeActionByPathAndComponent(this Variable item, string path, string component, params object[] arguments)
        {
            return item.GetRelativeActionByPathAndComponent(path, component, (IEnumerable<object>)arguments);
        }

        static public Action GetRelativeActionByPath(this Variable item, string full_path, IEnumerable<object> arguments)
        {
            return item.GetRelativeFunctionByPath(full_path, arguments.GetTypes())
                .IfNotNull(f => f.CreateAction(arguments));
        }
        static public Action GetRelativeActionByPath(this Variable item, string full_path, params object[] arguments)
        {
            return item.GetRelativeActionByPath(full_path, (IEnumerable<object>)arguments);
        }
    }
}