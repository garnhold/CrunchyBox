using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_Member_Function
    {
        static private OperationCache<Function, Type, string, ContentsEnumerable<Type>> GET_FUNCTION_BY_COMPONENT = ReflectionCache.Get().NewOperationCache<Function, Type, string, ContentsEnumerable<Type>>("GET_FUNCTION_BY_COMPONENT", delegate(Type type, string component, ContentsEnumerable<Type> parameter_types) {
            component = component.TrimSuffix("()");

            return Function_MethodInfo.New(type, component, parameter_types);
        });
        static public Function GetFunctionByComponent(this Type item, string component, IEnumerable<Type> parameter_types)
        {
            return GET_FUNCTION_BY_COMPONENT.Fetch(item, component, new ContentsEnumerable<Type>(parameter_types));
        }
        static public Function GetFunctionByComponent(this Type item, string component, params Type[] parameter_types)
        {
            return item.GetFunctionByComponent(component, (IEnumerable<Type>)parameter_types);
        }

        static private OperationCache<Function, Type, string, string, ContentsEnumerable<Type>> GET_FUNCTION_BY_PATH_AND_COMPONENT = ReflectionCache.Get().NewOperationCache("GET_FUNCTION_BY_PATH_AND_COMPONENT", delegate(Type type, string path, string component, ContentsEnumerable<Type> parameter_types) {
            if (path.IsVisible())
            {
                PathResolver path_resolver = type.GetPathResolver(path);

                if (path_resolver != null)
                {
                    Function function = path_resolver.GetOutputType().GetFunctionByComponent(component, parameter_types);

                    if (function != null)
                        return new Function_Path(function, path_resolver);
                }
            }

            return type.GetFunctionByComponent(component, parameter_types);
        });
        static public Function GetFunctionByPathAndComponent(this Type item, string path, string component, IEnumerable<Type> parameter_types)
        {
            return GET_FUNCTION_BY_PATH_AND_COMPONENT.Fetch(item, path, component, new ContentsEnumerable<Type>(parameter_types));
        }
        static public Function GetFunctionByPathAndComponent(this Type item, string path, string component, params Type[] parameter_types)
        {
            return item.GetFunctionByPathAndComponent(path, component, (IEnumerable<Type>)parameter_types);
        }

        static private OperationCache<Function, Type, string, ContentsEnumerable<Type>> GET_FUNCTION_BY_PATH = ReflectionCache.Get().NewOperationCache("GET_FUNCTION_BY_PATH", delegate(Type type, string full_path, ContentsEnumerable<Type> parameter_types) {
            string path;
            string component;

            full_path.SplitAtLastIndexOf(".", out path, out component);
            return type.GetFunctionByPathAndComponent(path, component, parameter_types);
        });
        static public Function GetFunctionByPath(this Type item, string full_path, IEnumerable<Type> parameter_types)
        {
            return GET_FUNCTION_BY_PATH.Fetch(item, full_path, new ContentsEnumerable<Type>(parameter_types));
        }
        static public Function GetFunctionByPath(this Type item, string full_path, params Type[] parameter_types)
        {
            return item.GetFunctionByPath(full_path, (IEnumerable<Type>)parameter_types);
        }
    }
}