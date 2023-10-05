using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenCharacter_Single : TokenCharacter
    {
        private char single;

        public TokenCharacter_Single(char s)
        {
            single = s;
        }

        public override bool Is(char character)
        {
            if (single == character)
                return true;

            return false;
        }

        public override IEnumerable<char> GetEntrys()
        {
            yield return single;
        }
    }
}