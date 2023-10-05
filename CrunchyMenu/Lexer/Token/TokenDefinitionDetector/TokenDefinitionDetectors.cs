using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    static public class TokenDefinitionDetectors
    {
        static public TokenDefinitionDetector String(string value)
        {
            return new TokenDefinitionDetector_String(value);
        }

        static public TokenDefinitionDetector Pattern(TokenPattern pattern)
        {
            return new TokenDefinitionDetector_Pattern(pattern);
        }
    }
}