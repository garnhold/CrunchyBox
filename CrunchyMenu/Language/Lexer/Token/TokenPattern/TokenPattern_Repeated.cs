using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class TokenPattern_Repeated : TokenPattern
    {
        private int minimum_count;
        private int maximum_count;

        private TokenPattern pattern;

        public TokenPattern_Repeated(TokenPattern p, int min, int max)
        {
            minimum_count = min;
            maximum_count = max;

            pattern = p;
        }

        public override int Detect(string text, int index)
        {
            int pattern_count = 0;

            while (index < text.Length)
            {
                int new_index = pattern.Detect(text, index);

                if (new_index != -1)
                {
                    pattern_count++;

                    if (pattern_count > maximum_count)
                        return -1;

                    index = new_index;
                }
                else
                {
                    if (pattern_count < minimum_count)
                        return -1;
                        
                    return index;
                }
            }

            return -1;
        }

        public override bool IsRequired()
        {
            if (minimum_count <= 0)
                return false;

            return pattern.IsRequired();
        }

        public override IEnumerable<char> GetEntrys()
        {
            return pattern.GetEntrys();
        }

        public override string GetPsuedoRegEx()
        {
            string contained = "(" + pattern.GetPsuedoRegEx() + ")";

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