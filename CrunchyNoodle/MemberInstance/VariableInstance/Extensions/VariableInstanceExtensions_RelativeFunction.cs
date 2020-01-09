using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class VariableInstanceExtensions_RelativeFunction
    {
        static public FunctionInstance GetRelativeFunctionInstanceByComponent(this VariableInstance item, string component, IEnumerable<Type> parameter_types)
        {
            return item.GetVariable().GetRelativeFunctionByComponent(component, parameter_types)
                .IfNotNull(f => f.CreateInstance(item.GetTargetInstance()));
        }
        static public FunctionInstance GetRelativeFunctionInstanceByComponent(this VariableInstance item, string component, params Type[] parameter_types)
        {
            return item.GetRelativeFunctionInstanceByComponent(component, (IEnumerable<Type>)parameter_types);
        }

        static public FunctionInstance GetRelativeFunctionInstanceByPathAndComponent(this VariableInstance item, string path, string component, IEnumerable<Type> parameter_types)
        {
            return item.GetVariable().GetRelativeFunctionByPathAndComponent(path, component, parameter_types)
                .IfNotNull(f => f.CreateInstance(item.GetTargetInstance()));
        }
        static public FunctionInstance GetRelativeFunctionInstanceByPathAndComponent(this VariableInstance item, string path, string component, params Type[] parameter_types)
        {
            return item.GetRelativeFunctionInstanceByPathAndComponent(path, component, (IEnumerable<Type>)parameter_types);
        }

        static public FunctionInstance GetRelativeFunctionInstanceByPath(this VariableInstance item, string full_path, IEnumerable<Type> parameter_types)
        {
            return item.GetVariable().GetRelativeFunctionByPath(full_path, parameter_types)
                .IfNotNull(f => f.CreateInstance(item.GetTargetInstance()));
        }
        static public FunctionInstance GetRelativeFunctionInstanceByPath(this VariableInstance item, string full_path, params Type[] parameter_types)
        {
            return item.GetRelativeFunctionInstanceByPath(full_path, (IEnumerable<Type>)parameter_types);
        }
    }

}