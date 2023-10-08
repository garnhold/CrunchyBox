using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Junk : TokenPattern
    {
        static public readonly TokenPattern INSTANCE = new TokenPattern_Junk();

        private TokenPattern_Junk()
        {
        }

        public override int Detect(string text, int index)
        {
            return -1;
        }

        public override IEnumerable<char> GetEntrys()
        {
            yield break;
        }

        public override string GetPsuedoRegEx()
        {
            return "????";
        }
    }
}