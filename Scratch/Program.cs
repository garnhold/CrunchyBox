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

            TokenDefinition whole_number = new TokenDefinition(
                TokenPatterns.Sequence(
                    TokenCharacterSets.Single('-').MakeOptional(),
                    TokenCharacterSets.Numeric().MakeOneOrMore()
                )
            );

            TokenDefinition decimal_number = new TokenDefinition(
                TokenPatterns.Sequence(
                    TokenCharacterSets.Single('-').MakeOptional(),
                    TokenCharacterSets.Numeric().MakeZeroOrMore(),
                    TokenCharacterSets.Single('.').MakeSingle(),
                    TokenCharacterSets.Numeric().MakeZeroOrMore()
                )
            );

            TokenMode string_mode = new TokenMode();

            TokenDefinition string_opening = new TokenDefinition(
                TokenCharacterSets.Single('"').MakeSingle(),
                TokenConsumers.ModePusher(string_mode)
            );

            TokenDefinition old_string_fragment = new TokenDefinition(
                TokenCharacterSets.List('\\', '"').MakeInverse().MakeOneOrMore()
            );

            TokenDefinition string_fragment = new TokenDefinition(
                TokenPatterns.Junk()
            );

            TokenDefinition string_escaped = new TokenDefinition(
                TokenPatterns.Sequence(
                    TokenCharacterSets.Single('\\').MakeSingle(),
                    TokenCharacterSets.All().MakeSingle()
                )
            );

            TokenDefinition string_closing = new TokenDefinition(
                TokenCharacterSets.Single('"').MakeSingle(),
                TokenConsumers.ModePopper(string_mode)
            );

            TokenDefinition public_keyword = new TokenDefinition("public");
            TokenDefinition new_keyword = new TokenDefinition("new");

            string_mode.SetJunkTokenDefinition(string_fragment);
            string_mode.AddTokenDefinitions(
                string_escaped,
                string_closing
            );

            mode.AddTokenDefinitions(
                whitespace,
                id,
                whole_number,
                decimal_number,
                public_keyword,
                new_keyword,
                string_opening
            );

            lexer.Tokenize("what is -.3 newa -145 \"public \\\"what\\\"\" 7 going public 3.1 new  \t on today in public")
                .Process(t => Console.WriteLine(t));

            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
