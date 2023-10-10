using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class SiT
    {
        private Lexer lexer;
        private FragmentDefinition<TokenPattern> parser;

        static private SiT INSTANCE;
        static public SiT GetInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new SiT();

            return INSTANCE;
        }

        private class Count
        {
            public readonly int min;
            public readonly int max;

            public Count(int mi, int ma)
            {
                min = mi;
                max = ma;
            }
        }

        private SiT()
        {
            TokenMode default_mode = new TokenMode();
            TokenMode set_mode = new TokenMode();
            TokenMode repeat_mode = new TokenMode();

            TokenDefinition t_whitespace = TokenDefinitions.Ignore(
                TokenCharacterSets.Whitespace().MakeOneOrMore()
            );

            TokenDefinition t_any_character = TokenDefinitions.Normal("any_character", ".");

            TokenDefinition t_one_or_more = TokenDefinitions.Normal("one_or_more", "+");
            TokenDefinition t_zero_or_more = TokenDefinitions.Normal("zero_or_more", "*");
            TokenDefinition t_optional = TokenDefinitions.Normal("optional", "?");

            TokenDefinition t_normal_character = TokenDefinitions.Normal("character",
                TokenPatterns.JunkCharacter()
            );

            TokenDefinition t_escaped_character = TokenDefinitions.Normal("escaped_character",
                TokenPatterns.Sequence(
                    TokenPatterns.OneCharacter('\\'),
                    TokenCharacterSets.All().MakeOne()
                )
            );

            TokenDefinition t_sequence_or = TokenDefinitions.Normal("sequence_or", "|");
            TokenDefinition t_sequence_start = TokenDefinitions.Normal("sequence_start", "(");
            TokenDefinition t_sequence_end = TokenDefinitions.Normal("sequence_end", ")");

            TokenDefinition t_set_start = TokenDefinitions.ModePusher("set_start", "[", set_mode);
            TokenDefinition t_set_end = TokenDefinitions.ModePopper("set_end", "]");

            TokenDefinition t_set_dash = TokenDefinitions.Normal("set_dash", "-");

            TokenDefinition t_repeat_start = TokenDefinitions.ModePusher("repeat_start", "{", repeat_mode);
            TokenDefinition t_repeat_end = TokenDefinitions.ModePopper("repeat_end", "}");

            TokenDefinition t_repeat_number = TokenDefinitions.Normal("repeat_number",
                TokenCharacterSets.Numeric().MakeOneOrMore()
            );
            TokenDefinition t_repeat_comma = TokenDefinitions.Normal("repeat_comma", ",");

            default_mode.AddTokenDefinitions(
                t_any_character,
                t_one_or_more,
                t_zero_or_more,
                t_optional,
                t_normal_character,
                t_escaped_character,
                t_sequence_start,
                t_sequence_or,
                t_sequence_end,
                t_set_start,
                t_repeat_start
            );

            set_mode.AddTokenDefinitions(
                t_normal_character,
                t_escaped_character,
                t_set_dash,
                t_set_end
            );

            repeat_mode.AddTokenDefinitions(
                t_repeat_number,
                t_repeat_comma,
                t_repeat_end
            );

            lexer = new Lexer(default_mode);

            FragmentDefinition<char> f_character = FragmentDefinitions
                .Any(
                    t_normal_character.MakeFragment(s => s[0]),
                    t_escaped_character.MakeFragment(s => s[1])
                );

            FragmentDefinition<Count> f_count = FragmentDefinitions.Any(
                t_zero_or_more.MakeFragment(s => new Count(0, int.MaxValue)),
                t_one_or_more.MakeFragment(s => new Count(1, int.MaxValue)),
                t_optional.MakeFragment(s => new Count(0, 1)),

                FragmentDefinitions.Sequence(
                    t_repeat_start.MakeFragment(),
                    t_repeat_number.MakeFragment(s => s.ParseInt()),
                    t_repeat_comma.MakeFragment(),
                    t_repeat_number.MakeFragment(s => s.ParseInt()),
                    t_repeat_end.MakeFragment(),
                    (d1, n1, d2, n2, d3) => new Count(n1, n2)
                )
            );
                
            FragmentDefinition<TokenCharacterSet> f_character_set = FragmentDefinitions.Any(
                FragmentDefinitions.Sequence(
                    f_character,
                    t_set_dash.MakeFragment(),
                    f_character,
                    (c1, d, c2) => TokenCharacterSets.Range(c1, c2)
                ),
                f_character.MakeConvert(c => TokenCharacterSets.Single(c))
            ).MakeOneOrMore().MakeConvert(cs => TokenCharacterSets.Combine(cs));

            FragmentDefinition<TokenCharacterSet> f_class = FragmentDefinitions.Any(
                t_any_character.MakeFragment(s => TokenCharacterSets.All()),

                FragmentDefinitions.Sequence(
                    t_set_start.MakeFragment(),
                    f_character_set,
                    t_set_end.MakeFragment(),
                    (d1, c, d2) => c
                )
            );
                
            FragmentDefinition_Any<TokenPattern> atom = new FragmentDefinition_Any<TokenPattern>("atom");

            FragmentDefinition<TokenPattern> sub_expression = atom
                .MakeOneOrMore()
                .MakeConvert(t => TokenPatterns.Sequence(t));

            FragmentDefinition_Any<TokenPattern> full_expression = new FragmentDefinition_Any<TokenPattern>("full_expression");

            full_expression.Initialize(
                sub_expression,

                sub_expression
                    .MakeTwoOrMoreJoined(t_sequence_or.MakeFragment())
                    .MakeConvert(subs => TokenPatterns.Any(subs)),

                FragmentDefinitions.Sequence(
                    sub_expression,
                    f_count,
                    (e, c) => {
                        if (c == null)
                            return e;

                        return e.MakeRepeated(c.min, c.max);
                    }
                ),

                FragmentDefinitions.Sequence(
                    t_sequence_start.MakeFragment(),
                    full_expression,
                    t_sequence_end.MakeFragment(),
                    (d1, e, d2) => e
                )
            );

            atom.Initialize(
                f_character
                    .MakeOneOrMore()
                    .MakeConvert(cs => TokenPatterns.String(cs.BuildString())),

                FragmentDefinitions.Sequence(
                    f_character,
                    f_count,
                    (c, n) => {
                        if (n == null)
                            return TokenPatterns.OneCharacter(c);

                        return TokenPatterns.Characters(n.min, n.max, c);
                    }
                ),

                FragmentDefinitions.Sequence(
                    f_class,
                    f_count.MakeOptional(),
                    (c, n) => {
                        if (n == null)
                            return TokenPatterns.OneCharacter(c);

                        return TokenPatterns.Characters(n.min, n.max, c);
                    }
                )
            );

            parser = full_expression;
        }

        public TokenPattern Parse(string text)
        {
            return parser.Parse(lexer, text)
                .Simplify();
        }
    }
}