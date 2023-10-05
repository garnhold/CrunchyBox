using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class TokenPatternCharacter
    {
        private int minimum_count;
        private int maximum_count;

        public abstract bool Is(char character);
        public abstract IEnumerable<char> GetEntrys();

        protected TokenPatternCharacter(int min, int max)
        {
            minimum_count = min;
            maximum_count = max;
        }

        public int GetMinimumCount()
        {
            return minimum_count;
        }

        public int GetMaximumCount()
        {
            return maximum_count;
        }
    }
}