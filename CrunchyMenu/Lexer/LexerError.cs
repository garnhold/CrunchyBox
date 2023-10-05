using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class LexerError : ApplicationException
    {
        private string text;
        private int index;

        public LexerError(string t, int i)
        {
            text = t;
            index = i;
        }
    }
}