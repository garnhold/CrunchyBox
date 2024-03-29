﻿using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenConsumers
    {
        static public TokenConsumer Normal()
        {
            return TokenConsumer_Normal.INSTANCE;
        }

        static public TokenConsumer Ignore()
        {
            return TokenConsumer_Ignore.INSTANCE;
        }

        static public TokenConsumer ModePusher(TokenModeInstance token_mode_definition)
        {
            return new TokenConsumer_ModePusher(token_mode_definition);
        }
        static public TokenConsumer ModePopper()
        {
            return new TokenConsumer_ModePopper();
        }
    }
}