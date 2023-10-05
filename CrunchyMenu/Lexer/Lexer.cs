using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class Lexer
    {
        private TokenModeDefinition default_token_mode_definition;

        public Lexer(TokenModeDefinition d)
        {
            default_token_mode_definition = d;
        }

        public IEnumerable<TokenInstance> Tokenize(string text)
        {
            if (text != null)
            {
                int index = 0;
                Tokenizer tokenizer = new Tokenizer(default_token_mode_definition);

                while (index < text.Length)
                {
                    if (tokenizer.Detect(text, index, out int end_index, out TokenDefinition token_definition))
                    {
                        if (token_definition.OnConsume(tokenizer))
                        {
                            yield return new TokenInstance(
                                text.SubSection(index, end_index),
                                token_definition
                            );
                        }

                        index = end_index;
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