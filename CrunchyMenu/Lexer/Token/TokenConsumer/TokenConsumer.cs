using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class TokenConsumer
    {
        public abstract bool OnConsume(Tokenizer tokenizer);
    }
}