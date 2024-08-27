using System;
using System.IO;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public partial class Filename
    {
        static public string GetRelativePath(string path, string base_path)
        {
            path = GetAbsolutePath(path);
            base_path = GetAbsoluteDirectory(base_path);

            if(path.TryTrimPrefix(base_path, out string calculated_relative))
                return calculated_relative;
                
            List<string> base_components = base_path.SplitOn("/").ToList();
            List<string> path_components = path.SplitOn("/").ToList();
            int index = base_components.FindIndexOfFirstElementNotEqual(path_components);

            calculated_relative = (base_components.Count - index - 1).RepeatOperation(() => "..")
                .Append(path_components.Offset(index))
                .Join("/");

            string recalculated_path = GetAbsolutePath(Path.Combine(base_path, calculated_relative));
            if (path != recalculated_path)
            {
                throw new SanityCheckException(Enumerable.New(
                    "The calculated relative path wasn't as expected:",
                    "path = " + path.StyleAsDoubleQuoteLiteral(),
                    "base_path = " + base_path.StyleAsDoubleQuoteLiteral(),
                    "calculated_relative = " + calculated_relative.StyleAsDoubleQuoteLiteral()
                ).Join("\n"));
            }

            return calculated_relative;
        }
        static public string GetRelativePath(string path)
        {
            return GetRelativePath(path, Directory.GetCurrentDirectory());
        }
    }
}