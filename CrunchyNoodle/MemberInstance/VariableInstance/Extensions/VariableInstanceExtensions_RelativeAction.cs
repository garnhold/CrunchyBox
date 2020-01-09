using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class VariableInstanceExtensions_RelativeAction
    {
        static public ActionInstance GetRelativeActionInstanceByComponent(this VariableInstance item, string component, IEnumerable<object> arguments)
        {
            return item.GetVariable().GetRelativeActionByComponent(component, arguments)
                .IfNotNull(a => a.CreateInstance(item.GetTargetInstance()));
        }
        static public ActionInstance GetRelativeActionInstanceByComponent(this VariableInstance item, string component, params object[] arguments)
        {
            return item.GetRelativeActionInstanceByComponent(component, (IEnumerable<Type>)arguments);
        }

        static public ActionInstance GetRelativeActionInstanceByPathAndComponent(this VariableInstance item, string path, string component, IEnumerable<object> arguments)
        {
            return item.GetVariable().GetRelativeActionByPathAndComponent(path, component, arguments)
                .IfNotNull(a => a.CreateInstance(item.GetTargetInstance()));
        }
        static public ActionInstance GetRelativeActionInstanceByPathAndComponent(this VariableInstance item, string path, string component, params object[] arguments)
        {
            return item.GetRelativeActionInstanceByPathAndComponent(path, component, (IEnumerable<Type>)arguments);
        }

        static public ActionInstance GetRelativeActionInstanceByPath(this VariableInstance item, string full_path, IEnumerable<object> arguments)
        {
            return item.GetVariable().GetRelativeActionByPath(full_path, arguments)
                .IfNotNull(a => a.CreateInstance(item.GetTargetInstance()));
        }
        static public ActionInstance GetRelativeActionInstanceByPath(this VariableInstance item, string full_path, params object[] arguments)
        {
            return item.GetRelativeActionInstanceByPath(full_path, (IEnumerable<Type>)arguments);
        }
    }

}