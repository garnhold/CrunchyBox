using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenConsumer_Normal : TokenConsumer
    {
        static public readonly TokenConsumer_Normal INSTANCE = new TokenConsumer_Normal();

        private TokenConsumer_Normal()
        {
        }

        public override bool OnConsume(Tokenizer tokenizer)
        {
            return true;
        }
    }
}