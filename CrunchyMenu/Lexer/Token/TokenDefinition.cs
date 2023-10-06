using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenDefinition
    {
        private TokenPattern pattern;
        private TokenConsumer consumer;

        public TokenDefinition(TokenPattern p, TokenConsumer c)
        {
            pattern = p;
            consumer = c;
        }

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

        public string GetPsuedoRegEx()
        {
            return pattern.GetPsuedoRegEx();
        }
    }
}