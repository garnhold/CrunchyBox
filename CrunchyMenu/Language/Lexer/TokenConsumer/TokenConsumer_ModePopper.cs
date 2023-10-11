using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenConsumer_ModePopper : TokenConsumer
    {
        public TokenConsumer_ModePopper()
        {
        }

        public override bool OnConsume(Tokenizer tokenizer)
        {
            tokenizer.PopTokenMode();

            return true;
        }
    }
}