using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenDefinition
    {
        private TokenPattern pattern;
        private TokenDefinitionConsumer consumer;

        public TokenDefinition(TokenPattern p, TokenDefinitionConsumer c)
        {
            pattern = p;
            consumer = c;
        }

        public TokenDefinition(TokenPattern p) : this(p, TokenDefinitionConsumer_Normal.INSTANCE) { }

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
    }
}