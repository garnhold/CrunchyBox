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

            TokenDefinition whitespace = TokenDefinitions.IgnoreSiT("whitespace", "[\t\r\n ]+");

            TokenDefinition id = TokenDefinitions.NormalSiT("id", "[A-Za-z_][A-Za-z0-9_]*");
            TokenDefinition whole_number = TokenDefinitions.NormalSiT("whole_number", "-?[0-9]+");
            TokenDefinition decimal_number = TokenDefinitions.NormalSiT("decimal_number", "-?[0-9]*\\.[0-9]*");

            TokenMode string_mode = new TokenMode();

            TokenDefinition string_opening = TokenDefinitions.ModePusherSiT("string_opening", "\"", string_mode);
            TokenDefinition string_fragment = TokenDefinitions.Normal("string_fragment", TokenPatterns.JunkString());
            TokenDefinition string_escaped = TokenDefinitions.NormalSiT("escaped_character", "\\\\.");
            TokenDefinition string_closing = TokenDefinitions.ModePopperSiT("string_closing", "\"");

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

            lexer.Tokenize("what is hahaha public 4.34 -1 43 wha23")
                .Process(t => Console.WriteLine(t));

            string input = "\"what is going \\nOn here?\"";

            lexer.Tokenize(input)
                .Process(t => Console.WriteLine(t));

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
