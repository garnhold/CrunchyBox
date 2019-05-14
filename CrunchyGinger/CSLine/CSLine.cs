using System;
using System.IO;
using System.Text;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyGinger
{
    public abstract class CSLine
    {
        public abstract string Translate(string input);

        static public string Single(string text)
        {
            return new CSLine_Simple().Translate(text);
        }
        static public string Single(string text, IEnumerable<KeyValuePair<string, string>> pairs)
        {
            return new CSLine_VariableTable(pairs).Translate(text);
        }
        static public string Single(string text, params KeyValuePair<string, string>[] pairs)
        {
            return new CSLine_VariableTable(pairs).Translate(text);
        }
        static public string Single(string text, IEnumerable<string> pairs)
        {
            return new CSLine_VariableTable(pairs).Translate(text);
        }
        static public string Single(string text, params string[] pairs)
        {
            return new CSLine_VariableTable(pairs).Translate(text);
        }

        public CSLine()
        {
        }
    }
}