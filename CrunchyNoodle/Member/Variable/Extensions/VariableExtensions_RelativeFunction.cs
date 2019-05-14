using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class VariableExtensions_RelativeFunction
    {
        static private Function CreateRelativeFunction(Variable item, Function function)
        {
            if (item != null)
                return new Function_Relative(item, function);

            return null;
        }

        static public Function GetRelativeFunctionByComponent(this Variable item, string component, IEnumerable<Type> parameter_types)
        {
            return CreateRelativeFunction(item, item.GetVariableType().GetFunctionByComponent(component, parameter_types));
        }
        static public Function GetRelativeFunctionByComponent(this Variable item, string component, params Type[] parameter_types)
        {
            return item.GetRelativeFunctionByComponent(component, (IEnumerable<Type>)parameter_types);
        }

        static public Function GetRelativeFunctionByPathAndComponent(this Variable item, string path, string component, IEnumerable<Type> parameter_types)
        {
            return CreateRelativeFunction(item, item.GetVariableType().GetFunctionByPathAndComponent(path, component, parameter_types));
        }
        static public Function GetRelativeFunctionByPathAndComponent(this Variable item, string path, string component, params Type[] parameter_types)
        {
            return item.GetRelativeFunctionByPathAndComponent(path, component, (IEnumerable<Type>)parameter_types);
        }

        static public Function GetRelativeFunctionByPath(this Variable item, string full_path, IEnumerable<Type> parameter_types)
        {
            return CreateRelativeFunction(item, item.GetVariableType().GetFunctionByPath(full_path, parameter_types));
        }
        static public Function GetRelativeFunctionByPath(this Variable item, string full_path, params Type[] parameter_types)
        {
            return item.GetRelativeFunctionByPath(full_path, (IEnumerable<Type>)parameter_types);
        }
    }
}