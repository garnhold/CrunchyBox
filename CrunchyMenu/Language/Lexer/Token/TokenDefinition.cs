using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenDefinition
    {
        private string name;

        private TokenPattern pattern;
        private TokenConsumer consumer;

        public TokenDefinition(string n, TokenPattern p, TokenConsumer c)
        {
            name = n;

            pattern = p;
            consumer = c;
        }

        public TokenDefinition(TokenPattern p, TokenConsumer c) : this(null, p, c) { }

        public TokenDefinition(string n, TokenPattern p) : this(n, p, TokenConsumers.Normal()) { }
        public TokenDefinition(TokenPattern p) : this(p, TokenConsumers.Normal()) { }

        public bool OnConsume(Tokenizer tokenizer)
        {
            return consumer.OnConsume(tokenizer);
        }

        public int Detect(string text, int index)
        {
            return pattern.Detect(text, index);
        }

        public IEnumerable<char> GetEntrys()
        {
            return pattern.GetEntrys();
        }

        public string GetLabel()
        {
            return name.Coalesce(() => GetPsuedoRegEx());
        }

        public string GetPsuedoRegEx()
        {
            return pattern.GetPsuedoRegEx();
        }

        public bool IsJunk()
        {
            if (pattern == TokenPattern_Junk.INSTANCE)
                return true;

            return false;
        }

        public TokenPattern GetTokenPattern()
        {
            return pattern;
        }

        public TokenConsumer GetTokenConsumer()
        {
            return consumer;
        }

        public override string ToString()
        {
            return GetLabel();
        }
    }
}