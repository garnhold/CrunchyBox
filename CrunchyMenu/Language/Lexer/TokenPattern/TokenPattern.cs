using System;
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

        public virtual bool TrySimplify(out TokenPattern output) { output = null; return false; }
        public virtual bool TryAppend(TokenPattern to_append, out TokenPattern output) { output = null; return false; }

        static public implicit operator TokenPattern(string s)
        {
            return new TokenPattern_String(s);
        }

        protected TokenPattern()
        {
        }

        public TokenPattern Simplify()
        {
            TokenPattern pattern = this;

            while (true)
            {
                if (pattern.TrySimplify(out TokenPattern simpler) == false)
                    return pattern;

                pattern = simpler;
            }
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