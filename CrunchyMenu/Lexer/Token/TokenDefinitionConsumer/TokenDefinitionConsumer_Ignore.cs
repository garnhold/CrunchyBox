using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenDefinitionConsumer_Ignore : TokenDefinitionConsumer
    {
        static public readonly TokenDefinitionConsumer_Ignore INSTANCE = new TokenDefinitionConsumer_Ignore();

        private TokenDefinitionConsumer_Ignore()
        {
        }

        public override bool OnConsume(Tokenizer tokenizer)
        {
            return false;
        }
    }
}