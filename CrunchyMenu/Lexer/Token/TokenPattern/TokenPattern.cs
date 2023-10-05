using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class TokenPattern
    {


        public abstract bool Detect(string text, int index, out int new_index);

        public abstract IEnumerable<char> GetEntrys();
    }
}