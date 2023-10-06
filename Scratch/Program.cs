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
            string needle = "publica what";

            TokenMode mode = new TokenMode();

            Lexer lexer = new Lexer(mode);

            TokenDefinition whitespace = new TokenDefinition(
                TokenCharacterSets.Whitespace().MakeOneOrMore(),
                TokenConsumers.Ignore()
            );

            TokenDefinition id = new TokenDefinition(
                TokenPatterns.Sequence(
                    TokenPatterns.SingleCharacter(
                        TokenCharacterSets.Alphabetic(), '_'
                    ),
                    TokenPatterns.ZeroOrMoreCharacters(
                        TokenCharacterSets.AlphaNumeric(), '_'
                    )
                )
            );

            TokenDefinition public_keyword = new TokenDefinition(
                TokenPatterns.String("public")
            );

            TokenDefinition new_keyword = new TokenDefinition(
                TokenPatterns.String("new")
            );

            mode.AddTokenDefinitions(
                whitespace,
                id,
                public_keyword,
                new_keyword
            );

            lexer.Tokenize("what is newa publics going public new  \t on today in public")
                .Process(t => Console.WriteLine(t));

            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
