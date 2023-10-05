using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenDefinition
    {
        private TokenDefinitionDetector detector;
        private TokenDefinitionConsumer consumer;

        public TokenDefinition(TokenDefinitionDetector d, TokenDefinitionConsumer c)
        {
            detector = d;
            consumer = c;
        }

        public TokenDefinition(TokenDefinitionDetector d) : this(d, TokenDefinitionConsumer_Normal.INSTANCE) { }

        public bool OnConsume(Tokenizer tokenizer)
        {
            return consumer.OnConsume(tokenizer);
        }

        public int Detect(string text, int index)
        {
            return detector.Detect(text, index);
        }

        public IEnumerable<char> GetEntrys()
        {
            return detector.GetEntrys();
        }
    }
}