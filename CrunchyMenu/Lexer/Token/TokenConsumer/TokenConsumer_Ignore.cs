using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenConsumer_Ignore : TokenConsumer
    {
        static public readonly TokenConsumer_Ignore INSTANCE = new TokenConsumer_Ignore();

        private TokenConsumer_Ignore()
        {
        }

        public override bool OnConsume(Tokenizer tokenizer)
        {
            return false;
        }
    }
}