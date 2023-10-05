using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPatternCharacter_Multiple : TokenPatternCharacter
    {
        private HashSet<char> characters;

        public TokenPatternCharacter_Multiple(IEnumerable<char> c, int min, int max) : base(min, max)
        {
            characters = c.ToHashSet();
        }

        public override bool Is(char c)
        {
            if (characters.Contains(c))
                return true;

            return false;
        }

        public override IEnumerable<char> GetEntrys()
        {
            return characters;
        }
    }
}