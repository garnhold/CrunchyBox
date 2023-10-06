﻿using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class TokenPattern
    {
        public abstract int Detect(string text, int index);

        public abstract IEnumerable<char> GetEntrys();

        public abstract string GetPsuedoRegEx();

        protected TokenPattern()
        {
        }

        public virtual bool IsRequired()
        {
            return true;
        }

        public override string ToString()
        {
            return GetPsuedoRegEx();
        }
    }
}