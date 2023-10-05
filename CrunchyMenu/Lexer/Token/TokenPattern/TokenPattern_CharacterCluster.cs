using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_CharacterCluster : TokenPattern
    {
        private TokenCharacter character;

        private int minimum_count;
        private int maximum_count;

        public TokenPattern_CharacterCluster(TokenCharacter c, int min, int max)
        {
            character = c;

            minimum_count = min;
            maximum_count = max;
        }

        public override int Detect(string text, int index)
        {
            int i;
            int count = 0;

            for(i = index; i < text.Length; i++)
            {
                if(character.Is(text[i]) == false)
                    break;

                count++;

                if (count > maximum_count)
                    return i;
            }

            if (count >= minimum_count)
                return i;

            return -1;
        }

        public override bool IsRequired()
        {
            if (minimum_count >= 1)
                return true;

            return false;
        }

        public override IEnumerable<char> GetEntrys()
        {
            return character.GetEntrys();
        }
    }
}