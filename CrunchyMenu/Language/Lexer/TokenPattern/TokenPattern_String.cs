using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_String : TokenPattern
    {
        private string value;

        public TokenPattern_String(string v)
        {
            value = v;
        }

        public override int Detect(string text, int index)
        {
            if (text.IsSubstring(index, value))
                return index + value.Length;

            return -1;
        }

        public override IEnumerable<char> GetEntrys()
        {
            yield return value.GetFirst();
        }

        public override string GetPsuedoRegEx()
        {
            return value.RegexEscape();
        }

        public override bool TryAppend(TokenPattern to_append, out TokenPattern output)
        {
            if (to_append.Convert<TokenPattern_String>(out TokenPattern_String as_string))
            {
                output = new TokenPattern_String(GetValue() + as_string.GetValue());
                return true;
            }

            output = null;
            return false;
        }

        public override bool TrySimplify(out TokenPattern output)
        {
            if (value.Length == 0)
            {
                output = null;
                return true;
            }

            output = null;
            return false;
        }

        public string GetValue()
        {
            return value;
        }
    }
}