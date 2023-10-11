using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenModeExtensions_AutoToken
    {
        static public AutoToken CreateAutoToken(this TokenMode item)
        {
            return new AutoToken(item);
        }

        static public Operation<TokenDefinition, string> CreateTOK(this TokenMode item)
        {
            return item.CreateAutoToken().GetTOK();
        }
    }
}