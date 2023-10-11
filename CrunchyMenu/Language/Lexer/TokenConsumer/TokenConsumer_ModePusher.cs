using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenConsumer_ModePusher : TokenConsumer
    {
        private TokenModeInstance token_mode_definition;

        public TokenConsumer_ModePusher(TokenModeInstance d)
        {
            token_mode_definition = d;
        }

        public override bool OnConsume(Tokenizer tokenizer)
        {
            tokenizer.PushTokenMode(token_mode_definition);

            return true;
        }
    }
}