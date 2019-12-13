using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace UnityUtilities
{
    static public class UnityAssetFile
    {
        static public IEnumerable<string> GetUnityAssetFiles(string filepath)
        {
            return Directory.GetFiles(filepath, "*", SearchOption.AllDirectories)
                .Narrow(p => p.EndsWithAny(".asset", ".prefab", ".unity"));
        }

        static public string GetGUID(string filepath)
        {
            return File.ReadAllText(filepath + ".meta")
                .RegexMatches("guid\\s*:\\s*([a-f0-9]{32})")[0]
                .Groups[1].Value;
        }
    }
}
