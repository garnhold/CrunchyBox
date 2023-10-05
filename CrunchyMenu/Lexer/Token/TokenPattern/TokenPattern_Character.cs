using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class TokenPattern_Character : TokenPattern
    {
        protected abstract bool IsCharacter(char character);

        public override int Detect(string text, int index)
        {
            if (index < text.Length)
            {
                if(IsCharacter(text[index]))
                    return index + 1;
            }

            return -1;
        }
    }
}