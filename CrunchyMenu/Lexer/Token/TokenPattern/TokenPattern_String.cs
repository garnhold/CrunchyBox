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
    }
}