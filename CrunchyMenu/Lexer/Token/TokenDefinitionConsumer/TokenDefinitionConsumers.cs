using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenDefinitionConsumers
    {
        static public TokenDefinitionConsumer Normal()
        {
            return TokenDefinitionConsumer_Normal.INSTANCE;
        }

        static public TokenDefinitionConsumer Ignore()
        {
            return TokenDefinitionConsumer_Ignore.INSTANCE;
        }

        static public TokenDefinitionConsumer ModePusher(TokenModeDefinition token_mode_definition)
        {
            return new TokenDefinitionConsumer_ModePusher(token_mode_definition);
        }
        static public TokenDefinitionConsumer ModePopper(TokenModeDefinition token_mode_definition)
        {
            return new TokenDefinitionConsumer_ModePopper(token_mode_definition);
        }
    }
}