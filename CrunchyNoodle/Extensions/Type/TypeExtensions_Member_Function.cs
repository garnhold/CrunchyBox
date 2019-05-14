using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_Member_Function
    {
        static public Function GetFunctionByComponent(this Type item, string component, IEnumerable<Type> parameter_types)
        {
            component = component.TrimSuffix("()");

            return Function_MethodInfo.New(item, component, parameter_types);
        }
        static public Function GetFunctionByComponent(this Type item, string component, params Type[] parameter_types)
        {
            return item.GetFunctionByComponent(component, (IEnumerable<Type>)parameter_types);
        }

        static public Function GetFunctionByPathAndComponent(this Type item, string path, string component, IEnumerable<Type> parameter_types)
        {
            if (path.IsVisible())
            {
                PathResolver path_resolver = item.GetPathResolver(path);

                if (path_resolver != null)
                {
                    Function function = path_resolver.GetOutputType().GetFunctionByComponent(component, parameter_types);

                    if (function != null)
                        return new Function_Path(function, path_resolver);
                }
            }

            return item.GetFunctionByComponent(component, parameter_types);
        }
        static public Function GetFunctionByPathAndComponent(this Type item, string path, string component, params Type[] parameter_types)
        {
            return item.GetFunctionByPathAndComponent(path, component, (IEnumerable<Type>)parameter_types);
        }

        static public Function GetFunctionByPath(this Type item, string full_path, IEnumerable<Type> parameter_types)
        {
            string path;
            string component;

            full_path.SplitAtLastIndexOf(".", out path, out component);
            return item.GetFunctionByPathAndComponent(path, component, parameter_types);
        }
        static public Function GetFunctionByPath(this Type item, string full_path, params Type[] parameter_types)
        {
            return item.GetFunctionByPath(full_path, (IEnumerable<Type>)parameter_types);
        }
    }
}