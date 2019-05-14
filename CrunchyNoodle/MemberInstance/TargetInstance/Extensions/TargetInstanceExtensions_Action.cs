using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class TargetInstanceExtensions_Action
    {
        static public ActionInstance GetActionInstanceByComponent(this TargetInstance item, string component, IEnumerable<object> arguments)
        {
            return item.GetTargetType().GetActionByComponent(component, arguments)
                .IfNotNull(a => a.CreateInstance(item));
        }
        static public ActionInstance GetActionInstanceByComponent(this TargetInstance item, string component, params object[] arguments)
        {
            return item.GetActionInstanceByComponent(component, (IEnumerable<object>)arguments);
        }

        static public ActionInstance GetActionInstanceByPathAndComponent(this TargetInstance item, string path, string component, IEnumerable<object> arguments)
        {
            return item.GetTargetType().GetActionByPathAndComponent(path, component, arguments)
                .IfNotNull(a => a.CreateInstance(item));
        }
        static public ActionInstance GetActionInstanceByPathAndComponent(this TargetInstance item, string path, string component, params object[] arguments)
        {
            return item.GetActionInstanceByPathAndComponent(path, component, (IEnumerable<object>)arguments);
        }

        static public ActionInstance GetActionInstanceByPath(this TargetInstance item, string full_path, IEnumerable<object> arguments)
        {
            return item.GetTargetType().GetActionByPath(full_path, arguments)
                .IfNotNull(a => a.CreateInstance(item));
        }
        static public ActionInstance GetActionInstanceByPath(this TargetInstance item, string full_path, params object[] arguments)
        {
            return item.GetActionInstanceByPath(full_path, (IEnumerable<object>)arguments);
        }

        static public ActionInstance GetActionInstanceByParentablePath(this TargetInstance item, TargetInstance parent, string full_path, IEnumerable<object> arguments)
        {
            if (full_path.TryTrimPrefix("parent.", out full_path))
                return parent.GetActionInstanceByPath(full_path, arguments);

            return item.GetActionInstanceByPath(full_path, arguments);
        }
        static public ActionInstance GetActionInstanceByParentablePath(this TargetInstance item, TargetInstance parent, string full_path, params object[] arguments)
        {
            return item.GetActionInstanceByParentablePath(parent, full_path, (IEnumerable<object>)arguments);
        }
    }
}