using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_Member_Variable
    {
        static private OperationCache<Variable, Type, string> GET_VARIABLE_BY_COMPONENT = ReflectionCache.Get().NewOperationCache<Variable, Type, string>("GET_VARIABLE_BY_COMPONENT", delegate(Type type, string component) {
            switch (component)
            {
                case "": return Variable_This.New(type);
                case "this": return Variable_This.New(type);
            }

            string index;
            string array;
            if (component.RegexPartOut("(.*)\\[([0-9]+)\\]$", out array, out index) == 2)
            {
                return Variable_Prop.New(type, array).IfNotNull(v =>
                    new Variable_Element(v, index.ParseInt())
                );
            }

            return Variable_Prop.New(type, component);
        });
        static public Variable GetVariableByComponent(this Type item, string component)
        {
            return GET_VARIABLE_BY_COMPONENT.Fetch(item, component);
        }

        static private OperationCache<Variable, Type, string, string> GET_VARIABLE_BY_PATH_AND_COMPONENT = ReflectionCache.Get().NewOperationCache("GET_VARIABLE_BY_PATH_AND_COMPONENT", delegate(Type type, string path, string component) {
            if (path.IsVisible())
            {
                PathResolver path_resolver = type.GetPathResolver(path);

                if (path_resolver != null)
                {
                    Variable variable = path_resolver.GetOutputType().GetVariableByComponent(component);

                    if (variable != null)
                        return new Variable_Path(variable, path_resolver);
                }

                return null;
            }

            return type.GetVariableByComponent(component);
        });
        static public Variable GetVariableByPathAndComponent(this Type item, string path, string component)
        {
            return GET_VARIABLE_BY_PATH_AND_COMPONENT.Fetch(item, path, component);
        }

        static private OperationCache<Variable, Type, string> GET_VARIABLE_BY_PATH = ReflectionCache.Get().NewOperationCache("GET_VARIABLE_BY_PATH", delegate(Type type, string full_path) {
            string path;
            string component;

            full_path.SplitAtLastIndexOf(".", out path, out component);
            return type.GetVariableByPathAndComponent(path, component);
        });
        static public Variable GetVariableByPath(this Type item, string full_path)
        {
            return GET_VARIABLE_BY_PATH.Fetch(item, full_path);
        }
    }
}