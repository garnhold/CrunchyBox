using System;
using System.Collections;
using System.Collections.Generic;

using System.Text.RegularExpressions;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class TypeExtensions_Member_PathResolver
    {
        static private OperationCache<PathResolver, Type, string> GET_PATH_RESOLVER = ReflectionCache.Get().NewOperationCache("GET_PATH_RESOLVER", delegate(Type type, string path) {
            List<Variable> variables = type.CreateVariablePath(path);

            if (variables.IsNotEmpty())
                return new PathResolver(variables);

            return null;
        });
        static public PathResolver GetPathResolver(this Type item, string path)
        {
            return GET_PATH_RESOLVER.Fetch(item, path);
        }
    }
}