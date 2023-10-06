using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenCharacterSet
    {
        private char[] characters;
        private bool[] character_map;

        private string psuedo_regex;

        static public implicit operator TokenCharacterSet(char character)
        {
            return new TokenCharacterSet(character);
        }

        public TokenCharacterSet(IEnumerable<char> c)
        {
            characters = c.ToArray();
            character_map = new bool[char.MaxValue];

            characters.Process(z => character_map[z] = true);
        }

        public TokenCharacterSet(params char[] c) : this((IEnumerable<char>)c) { }

        public bool Is(char c)
        {
            if (character_map[c])
                return true;

            return false;
        }

        public IEnumerable<char> GetCharacters()
        {
            return characters;
        }

        public string GetPsuedoRegEx()
        {
            if (psuedo_regex == null)
            {
                List<char> singles = new List<char>();
                List<Dough.Tuple<char, char>> ranges = new List<Dough.Tuple<char, char>>();

                char start = '\0';
                char last = start;
                bool is_started = false;

                for (char i = '\0'; i < character_map.Length; i++)
                {
                    if (character_map[i])
                    {
                        if (is_started == false)
                        {
                            start = i;
                            is_started = true;
                        }

                        last = i;
                    }
                    else
                    {
                        if (is_started)
                        {
                            if (start == last)
                                singles.Add(start);
                            else
                                ranges.Add(Dough.Tuple.New(start, last));

                            is_started = false;
                        }
                    }
                }

                psuedo_regex = "[" +
                    singles.BuildString().RegexEscape() +
                    ranges
                        .Convert(r => r.item1.ToString().RegexEscape() + "-" + r.item2.ToString().RegexEscape())
                        .Join("") +
                "]";
            }

            return psuedo_regex;
        }
    }
}