using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenModeExtensions_Instance
    {
        static public TokenModeInstance Instance(this TokenMode item, IEnumerable<TokenDefinition> additional_token_definitions)
        {
            return new TokenModeInstance(item, additional_token_definitions);
        }
        static public TokenModeInstance Instance(this TokenMode item, params TokenDefinition[] additional_token_definitions)
        {
            return item.Instance((IEnumerable<TokenDefinition>)additional_token_definitions);
        }
    }
}