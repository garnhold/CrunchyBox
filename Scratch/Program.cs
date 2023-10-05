using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using System.Threading;
using System.Threading.Tasks;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Recipe;
using Crunchy.Sandwich;
using Crunchy.Dinner;
using Crunchy.Menu;

namespace Scratch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TokenDefinition token = new TokenDefinition(
                TokenDefinitionDetectors.Pattern(
                    TokenPatterns.Sequence(
                        TokenPatterns.Multiple(
                            TokenPatterns.CharacterRange('a', 'z'),
                            TokenPatterns.CharacterRange('A', 'Z'),
                            TokenPatterns.Character('_')
                        ).MakeAtleastOne(),
                        TokenPatterns.Multiple(
                            TokenPatterns.CharacterRange('a', 'z'),
                            TokenPatterns.CharacterRange('A', 'Z'),
                            TokenPatterns.CharacterRange('0', '9'),
                            TokenPatterns.Character('_')
                        ).MakeAnyAmount()
                    )
                )
            );

            token = new TokenDefinition(
                TokenDefinitionDetectors.Pattern(
                    TokenPatterns.Sequence(
                        TokenPatterns.AlphabeticalAndUnderscore().MakeAtleastOne(),
                        TokenPatterns.AlphaNumericAndUnderscore().MakeAnyAmount()
                    )
                )
            );

            Console.ReadLine();
        }

    }
}
