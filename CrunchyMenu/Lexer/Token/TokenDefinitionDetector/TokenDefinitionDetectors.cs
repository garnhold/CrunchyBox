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

        static public TokenDefinitionDetector Pattern(IEnumerable<TokenPatternCharacter> characters)
        {
            return new TokenDefinitionDetector_Pattern(characters);
        }
        static public TokenDefinitionDetector Pattern(params TokenPatternCharacter[] characters)
        {
            return Pattern((IEnumerable<TokenPatternCharacter>)characters);
        }
    }
}