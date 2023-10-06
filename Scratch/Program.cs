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
            string needle = "publica";

            TokenMode mode = new TokenMode();

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

            mode.AddTokenDefinitions(
                whitespace,
                id,
                public_keyword
            );

            for (int j = 0; j < 6; j++)
            {
                int cost = 1024 * 1024;

                Crunchy.Dough.Timer timer = new Crunchy.Dough.Timer();

                timer.Restart();
                for (int i = 0; i < cost; i++)
                {
                    mode.Detect(needle, 0, out int new_index, out TokenDefinition token_definition);

                    Console.WriteLine(token_definition.GetPsuedoRegEx());
                }
                Console.WriteLine(timer.GetElapsedTimeInSeconds() + "s for Detect");

                timer.Restart();
                for (int i = 0; i < cost; i++)
                {
                    mode.Detect2(needle, 0, out int new_index, out TokenDefinition token_definition);
                }
                Console.WriteLine(timer.GetElapsedTimeInSeconds() + "s for Detect2");

                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[A-Za-z0-9_]+");

                timer.Restart();
                for (int i = 0; i < cost; i++)
                {
                    if(needle.RegexIsMatch(regex))
                    {
                        int oup = 0 + needle.Length;
                    }
                }
                Console.WriteLine(timer.GetElapsedTimeInSeconds() + "s for Regex");

                Console.WriteLine();
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
