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

            TokenDefinition whitespace = new TokenDefinition("whitespace",
                TokenCharacterSets.Whitespace().MakeOneOrMore(),
                TokenConsumers.Ignore()
            );

            TokenDefinition id = new TokenDefinition("id",
                TokenPatterns.Sequence(
                    TokenPatterns.SingleCharacter(
                        TokenCharacterSets.Alphabetic(), '_'
                    ),
                    TokenPatterns.ZeroOrMoreCharacters(
                        TokenCharacterSets.AlphaNumeric(), '_'
                    )
                )
            );

            TokenDefinition whole_number = new TokenDefinition("whole_number",
                TokenPatterns.Sequence(
                    TokenCharacterSets.Single('-').MakeOptional(),
                    TokenCharacterSets.Numeric().MakeOneOrMore()
                )
            );

            TokenDefinition decimal_number = new TokenDefinition("decimal_number",
                TokenPatterns.Sequence(
                    TokenCharacterSets.Single('-').MakeOptional(),
                    TokenCharacterSets.Numeric().MakeZeroOrMore(),
                    TokenCharacterSets.Single('.').MakeSingle(),
                    TokenCharacterSets.Numeric().MakeZeroOrMore()
                )
            );

            TokenMode string_mode = new TokenMode();

            TokenDefinition string_opening = new TokenDefinition("string_opening",
                TokenCharacterSets.Single('"').MakeSingle(),
                TokenConsumers.ModePusher(string_mode)
            );

            TokenDefinition string_fragment = new TokenDefinition("string_fragment",
                TokenPatterns.Junk()
            );

            TokenDefinition string_escaped = new TokenDefinition("escaped_character",
                TokenPatterns.Sequence(
                    TokenCharacterSets.Single('\\').MakeSingle(),
                    TokenCharacterSets.All().MakeSingle()
                )
            );

            TokenDefinition string_closing = new TokenDefinition("string_closing",
                TokenCharacterSets.Single('"').MakeSingle(),
                TokenConsumers.ModePopper(string_mode)
            );

            TokenDefinition public_keyword = new TokenDefinition("public");
            TokenDefinition new_keyword = new TokenDefinition("new");

            string_mode.AddTokenDefinitions(
                string_fragment,
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

            lexer.Tokenize("what is -.3 newa -145 \"public crap?on all &*#(#))$ haha \\\"what\\\"\" 7 going public 3.1 new  \t on today in public")
                .Process(t => Console.WriteLine(t));

            FragmentDefinitions.Token(string_opening, s => "");

            /*
            ThisAssembly is why you probably need to pass around Language because
                you should allow for auto token fragments i.e. conversions from

???? maybe not?

                I did auto lexer tokens in llamaish fyi
                */

            FragmentDefinitions.Sequence("string",
                string_opening.MakeFragment(),
                FragmentDefinitions.Any(string_fragment.MakeFragment(), string_escaped.MakeFragment()).MakeZeroOrMore(),
                string_closing.MakeFragment(),
                (j1, b, j2) => "poop"
            );

            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
