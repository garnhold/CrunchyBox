using System;
using System.IO;

namespace Crunchy.Dough
{
    static public partial class Filename
    {
        static public string CleanPath(string input)
        {
            return input.Replace('\\', '/');
        }

        static public string CleanFilename(string input)
        {
            return input.RegexReplace("[^A-Za-z0-9_\\(\\)\\,\\.\\-\\+\\= ]", "_");
        }
    }
}