using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenDefinitionConsumer_Normal : TokenDefinitionConsumer
    {
        static public readonly TokenDefinitionConsumer_Normal INSTANCE = new TokenDefinitionConsumer_Normal();

        private TokenDefinitionConsumer_Normal()
        {
        }

        public override bool OnConsume(Tokenizer tokenizer)
        {
            return true;
        }
    }
}