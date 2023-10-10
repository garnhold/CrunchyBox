using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public abstract class FragmentDefinition
    {
        private string name;

        public abstract bool ConsumeWithoutProduct(IList<TokenInstance> tokens, int index, out int new_index);

        public abstract bool CanConsumeNone();
        public abstract string GetPsuedoRegEx();

        protected virtual string GetMaybeLabel() { return null; }

        public FragmentDefinition(string n)
        {
            name = n;
        }

        public string GetLabel()
        {
            return name.Coalesce(
                () => GetMaybeLabel(),
                () => GetPsuedoRegEx()
            );
        }

        public override string ToString()
        {
            return GetLabel();
        }
    }

    public abstract class FragmentDefinition<T> : FragmentDefinition
    {
        private Stack<int> consume_index_stack;

        protected abstract bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer);

        public FragmentDefinition(string n) : base(n)
        {
            consume_index_stack = new Stack<int>();
            consume_index_stack.Push(-1);
        }

        public bool Consume(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            if (index > consume_index_stack.Peek())
            {
                try
                {
                    consume_index_stack.Push(index);

                    return ConsumeInternal(tokens, index, out new_index, out producer);
                }
                finally
                {
                    consume_index_stack.Pop();
                }
            }

            new_index = -1;
            producer = null;
            return false;
        }
        public T Consume(IList<TokenInstance> tokens, int index, out int new_index)
        {
            if (Consume(tokens, index, out new_index, out Operation<T> producer))
                return producer();

            return default(T);
        }
        public T Consume(IList<TokenInstance> tokens, int index)
        {
            return Consume(tokens, index, out int new_index);
        }
        public T Consume(IList<TokenInstance> tokens)
        {
            return Consume(tokens, 0);
        }

        public T Parse(Lexer lexer, string text)
        {
            return Consume(lexer.Tokenize(text).ToArray());
        }

        public IEnumerable<FragmentDefinition<T>> GetSubAlternatives()
        {
            yield return this;

            if (CanConsumeNone())
                yield return FragmentDefinition_Skip<T>.INSTANCE;
        }

        public override bool ConsumeWithoutProduct(IList<TokenInstance> tokens, int index, out int new_index)
        {
            return Consume(tokens, index, out new_index, out Operation<T> producer);
        }
    }
}