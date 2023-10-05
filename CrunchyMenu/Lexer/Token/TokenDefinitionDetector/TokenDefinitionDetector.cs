using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class TokenDefinitionDetector
    {
        public abstract int Detect(string text, int index);

        public abstract IEnumerable<char> GetEntrys();
    }
}