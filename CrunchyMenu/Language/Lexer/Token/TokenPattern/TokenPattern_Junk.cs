using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Junk : TokenPattern
    {
        private JunkTokenBehaviour behaviour;

        public TokenPattern_Junk(JunkTokenBehaviour b)
        {
            behaviour = b;
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
            return behaviour.GetPsuedoRegEx();
        }

        public JunkTokenBehaviour GetBehaviour()
        {
            return behaviour;
        }
    }
}