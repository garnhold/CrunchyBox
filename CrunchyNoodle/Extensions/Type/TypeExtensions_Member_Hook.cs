using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;

    static public class TypeExtensions_Member_Hook
    {
        static private OperationCache<Hook, Type, string> GET_HOOK_BY_COMPONENT = ReflectionCache.Get().NewOperationCache<Hook, Type, string>("GET_HOOK_BY_COMPONENT", delegate (Type type, string component) {
            return Hook_Evt.New(type, component);
        });
        static public Hook GetHookByComponent(this Type item, string component)
        {
            return GET_HOOK_BY_COMPONENT.Fetch(item, component);
        }

        static private OperationCache<Hook, Type, string, string> GET_HOOK_BY_PATH_AND_COMPONENT = ReflectionCache.Get().NewOperationCache("GET_HOOK_BY_PATH_AND_COMPONENT", delegate (Type type, string path, string component) {
            if (path.IsVisible())
            {
                PathResolver path_resolver = type.GetPathResolver(path);

                if (path_resolver != null)
                {
                    Hook hook = path_resolver.GetOutputType().GetHookByComponent(component);

                    if (hook != null)
                        return new Hook_Path(hook, path_resolver);
                }
            }

            return type.GetHookByComponent(component);
        });
        static public Hook GetHookByPathAndComponent(this Type item, string path, string component)
        {
            return GET_HOOK_BY_PATH_AND_COMPONENT.Fetch(item, path, component);
        }

        static private OperationCache<Hook, Type, string> GET_HOOK_BY_PATH = ReflectionCache.Get().NewOperationCache("GET_HOOK_BY_PATH", delegate (Type type, string full_path) {
            string path;
            string component;

            full_path.SplitAtLastIndexOf(".", out path, out component);
            return type.GetHookByPathAndComponent(path, component);
        });
        static public Hook GetHookByPath(this Type item, string full_path)
        {
            return GET_HOOK_BY_PATH.Fetch(item, full_path);
        }
    }
}