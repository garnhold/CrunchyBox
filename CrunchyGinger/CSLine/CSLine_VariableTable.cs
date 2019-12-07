using System;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Ginger
{
    using Dough;
    
    public class CSLine_VariableTable : CSLine
    {
        private StringTable variables;

        static private Regex TRANSLATE_REGEX = "\\?([A-Za-z0-9_]+)!?( )?".CompileRegexFromPattern();

        private CSLine_VariableTable(StringTable v)
        {
            variables = v;
        }

        public CSLine_VariableTable(IEnumerable<KeyValuePair<string, string>> pairs) : this(new StringTable(pairs)) { }
        public CSLine_VariableTable(params KeyValuePair<string, string>[] pairs) : this(new StringTable(pairs)) { }
        public CSLine_VariableTable(IEnumerable<string> pairs) : this(new StringTable(pairs)) { }
        public CSLine_VariableTable(params string[] pairs) : this(new StringTable(pairs)) { }
        public CSLine_VariableTable() : this(new StringTable()) { }

        public override string Translate(string input)
        {
            return input.RegexReplace(TRANSLATE_REGEX, delegate(Match match) {
                string translation;

                if (variables.TryLookup(match.Groups[1].Value, out translation))
                {
                    string replacement = translation + match.Groups[2].Value;

                    if (replacement.IsVisible())
                        return replacement;

                    return "";
                }

                return match.Value;
            });
        }
    }
}