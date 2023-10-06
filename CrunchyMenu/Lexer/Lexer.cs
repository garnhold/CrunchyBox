using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class Lexer
    {
        private TokenMode default_token_mode;

        public Lexer(TokenMode d)
        {
            default_token_mode = d;
        }

        public IEnumerable<TokenInstance> Tokenize(string text)
        {
            if (text != null)
            {
                int index = 0;

                Tokenizer tokenizer = new Tokenizer(default_token_mode);

                while (index < text.Length)
                {
                    if (tokenizer.StepTokenizeInner(text, ref index, out TokenInstance token))
                    {
                        if (token != null)
                            yield return token;
                    }
                    else
                    {
                        TokenDefinition junk_token_definition = tokenizer
                            .GetCurrentJunkTokenDefinition();

                        if (junk_token_definition != null)
                        {
                            int junk_start = index;
                            int junk_end = index;

                            while (++index < text.Length)
                            {
                                if (tokenizer.StepTokenizeInner(text, ref index, out token))
                                    break;

                                junk_end = index;
                            }

                            yield return new TokenInstance(
                                text.SubSection(junk_start, junk_end + 1),
                                junk_token_definition
                            );

                            if (token != null)
                                yield return token;
                        }
                        else
                        {
                            throw new LexerError(text, index);
                        }
                    }
                }
            }
        }
    }
}