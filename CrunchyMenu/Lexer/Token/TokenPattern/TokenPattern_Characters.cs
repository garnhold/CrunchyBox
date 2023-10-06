using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Characters : TokenPattern
    {
        private TokenCharacterSet character_set;

        private int minimum_count;
        private int maximum_count;

        public TokenPattern_Characters(TokenCharacterSet s, int min, int max)
        {
            character_set = s;

            minimum_count = min;
            maximum_count = max;
        }

        public override int Detect(string text, int index)
        {
            int i;
            int count = 0;

            for(i = index; i < text.Length; i++)
            {
                if(character_set.Is(text[i]) == false)
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
            return character_set.GetCharacters();
        }

        public override string GetPsuedoRegEx()
        {
            string contained = character_set.GetPsuedoRegEx();

            if (minimum_count == 0 && maximum_count == 1)
                return contained + "?";

            if (minimum_count == 1 && maximum_count >= int.MaxValue)
                return contained + "+";

            if (minimum_count == 0 && maximum_count >= int.MaxValue)
                return contained + "*";

            return contained + "{" + minimum_count + "," + maximum_count + "}";
        }
    }
}