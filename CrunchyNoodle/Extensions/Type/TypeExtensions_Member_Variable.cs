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
        static public Variable GetVariableByComponent(this Type item, string component)
        {
            switch (component)
            {
                case "": return Variable_This.New(item);
                case "this": return Variable_This.New(item);
            }

            string index;
            string array;
            if(component.RegexPartOut("(.*)\\[([0-9]+)\\]$", out array, out index) == 2)
            {
                return Variable_Prop.New(item, array).IfNotNull(v =>
                    new Variable_Element(v, index.ParseInt())
                );
            }

            return Variable_Prop.New(item, component);
        }

        static public Variable GetVariableByPathAndComponent(this Type item, string path, string component)
        {
            if (path.IsVisible())
            {
                PathResolver path_resolver = item.GetPathResolver(path);

                if (path_resolver != null)
                {
                    Variable variable = path_resolver.GetOutputType().GetVariableByComponent(component);

                    if (variable != null)
                        return new Variable_Path(variable, path_resolver);
                }

                return null;
            }

            return item.GetVariableByComponent(component);
        }

        static public Variable GetVariableByPath(this Type item, string full_path)
        {
            string path;
            string component;

            full_path.SplitAtLastIndexOf(".", out path, out component);
            return item.GetVariableByPathAndComponent(path, component);
        }
    }
}