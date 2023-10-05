using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenConsumer_ModePopper : TokenConsumer
    {
        private TokenMode token_mode_definition;

        public TokenConsumer_ModePopper(TokenMode d)
        {
            token_mode_definition = d;
        }

        public override bool OnConsume(Tokenizer tokenizer)
        {
            tokenizer.PopTokenMode(token_mode_definition);

            return true;
        }
    }
}