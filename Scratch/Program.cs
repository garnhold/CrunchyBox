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

            TokenDefinition whitespace = TokenDefinitions.Ignore("whitespace",
                TokenCharacterSets.Whitespace().MakeOneOrMore()
            );

            Console.WriteLine(whitespace.GetPsuedoRegEx());

            TokenDefinition whitespace2 = TokenDefinitions.IgnoreSiT("whitespace2", "[\r\t\n ]+");
            Console.WriteLine(whitespace2.GetPsuedoRegEx());
            return;

            TokenDefinition id = TokenDefinitions.Normal("id",
                TokenPatterns.Sequence(
                    TokenPatterns.OneCharacter(
                        TokenCharacterSets.Alphabetic(), '_'
                    ),
                    TokenPatterns.ZeroOrMoreCharacters(
                        TokenCharacterSets.AlphaNumeric(), '_'
                    )
                )
            );

            TokenDefinition whole_number = TokenDefinitions.Normal("whole_number",
                TokenPatterns.Sequence(
                    TokenCharacterSets.Single('-').MakeOptional(),
                    TokenCharacterSets.Numeric().MakeOneOrMore()
                )
            );

            TokenDefinition decimal_number = TokenDefinitions.Normal("decimal_number",
                TokenPatterns.Sequence(
                    TokenCharacterSets.Single('-').MakeOptional(),
                    TokenCharacterSets.Numeric().MakeZeroOrMore(),
                    TokenCharacterSets.Single('.').MakeOne(),
                    TokenCharacterSets.Numeric().MakeZeroOrMore()
                )
            );

            TokenMode string_mode = new TokenMode();

            TokenDefinition string_opening = TokenDefinitions.ModePusher("string_opening",
                TokenCharacterSets.Single('"').MakeOne(),
                string_mode
            );

            TokenDefinition string_fragment = TokenDefinitions.Normal("string_fragment",
                TokenPatterns.JunkString()
            );

            TokenDefinition string_escaped = TokenDefinitions.Normal("escaped_character",
                TokenPatterns.Sequence(
                    TokenCharacterSets.Single('\\').MakeOne(),
                    TokenCharacterSets.All().MakeOne()
                )
            );

            TokenDefinition string_closing = TokenDefinitions.ModePopper("string_closing",
                TokenCharacterSets.Single('"').MakeOne()
            );

            TokenDefinition public_keyword = TokenDefinitions.Normal("public");
            TokenDefinition new_keyword = TokenDefinitions.Normal("new");

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

            string input = "\"what is going \\nOn here?\"";

            lexer.Tokenize(input)
                .Process(t => Console.WriteLine(t));

            /*
            ThisAssembly is why you probably need to pass around Language because
                you should allow for auto token fragments i.e. conversions from

???? maybe not?

                I did auto lexer tokens in llamaish fyi
                */

            FragmentDefinition<string> sf = FragmentDefinitions.Sequence("string",
                string_opening.MakeFragment(),
                FragmentDefinitions.Any(
                    string_fragment.MakeFragment(s => s), 
                    string_escaped.MakeFragment(s => s.ExpandEscapeSequences())
                ).MakeZeroOrMore(),
                string_closing.MakeFragment(),
                (j1, b, j2) => b.Join("")
            );

            Console.WriteLine("Result: " + sf.Parse(lexer, input));

            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
