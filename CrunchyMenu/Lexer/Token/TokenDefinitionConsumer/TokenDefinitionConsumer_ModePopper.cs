using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenDefinitionConsumer_ModePopper : TokenDefinitionConsumer
    {
        private TokenModeDefinition token_mode_definition;

        public TokenDefinitionConsumer_ModePopper(TokenModeDefinition d)
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