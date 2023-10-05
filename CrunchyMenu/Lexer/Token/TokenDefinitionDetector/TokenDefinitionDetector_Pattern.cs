using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenDefinitionDetector_Pattern : TokenDefinitionDetector
    {
        private List<TokenPatternCharacter> characters;

        public TokenDefinitionDetector_Pattern(IEnumerable<TokenPatternCharacter> c)
        {
            characters = c.ToList();
        }

        public override int Detect(string text, int index)
        {
            int character_count = 0;
            IEnumerator<TokenPatternCharacter> iterator = characters.GetEnumerator();

            while (index < text.Length)
            {
                if (iterator.Current.Is(text[index]))
                {
                    character_count++;

                    if (character_count >= iterator.Current.GetMaximumCount())
                        return -1;

                    index++;
                }
                else
                {
                    if (character_count < iterator.Current.GetMinimumCount())
                        return -1;

                    if (iterator.MoveNext() == false)
                        return index;
                }
            }

            return -1;
        }

        public override IEnumerable<char> GetEntrys()
        {
            foreach (TokenPatternCharacter character in characters)
            {
                foreach(char entry in character.GetEntrys())
                    yield return entry;

                if (character.GetMinimumCount() >= 1)
                    yield break;
            }
        }
    }
}