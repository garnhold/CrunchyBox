using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenModeExtensions_TOK
    {
        static public Operation<TokenDefinition, string> GetTOK(this TokenMode item)
        {
            return item.GetAutoTokenDefinition;
        }
    }
}