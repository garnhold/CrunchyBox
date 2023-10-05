using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class TokenCharacter
    {
        public abstract bool Is(char character);
        public abstract IEnumerable<char> GetEntrys();
    }
}