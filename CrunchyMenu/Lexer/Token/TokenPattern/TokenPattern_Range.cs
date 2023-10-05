﻿using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Range : TokenPattern
    {


        public TokenPattern_String(string v)
        {
            value = v;
        }

        public override int Detect(string text, int index)
        {
            if (text.IsSubstring(index, value))
                return index + value.Length;

            return index;
        }

        public override IEnumerable<char> GetEntrys()
        {
            yield return value.GetFirst();
        }
    }
}