using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinition_Joined<T> : FragmentDefinition<T[]>
    {
        private FragmentDefinition<T> fragment_definition;
        private FragmentDefinition joiner_definition;

        private int minimum_count;
        private int maximum_count;

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T[]> producer)
        {
            int best_index = -1;
            int current_index = index;
            List<Operation<T>> sub_producers = new List<Operation<T>>();

            while (fragment_definition.Consume(tokens, current_index, out current_index, out Operation<T> sub_producer))
            {
                sub_producers.Add(sub_producer);
                best_index = current_index;

                if (sub_producers.Count > maximum_count)
                    break;

                if (joiner_definition.ConsumeWithoutProduct(tokens, current_index, out current_index) == false)
                {
                    if (sub_producers.Count < minimum_count)
                        break;

                    new_index = best_index;
                    producer = () => sub_producers.Convert(p => p()).ToArray();
                    return true;
                }
            }

            new_index = -1;
            producer = null;
            return false;
        }

        protected override string GetMaybeLabel()
        {
            string inner = fragment_definition.GetLabel();
            string joiner = joiner_definition.GetLabel();

            if (minimum_count == 0 && maximum_count == int.MaxValue)
                return "(" + inner + "(" + joiner + inner + ")*)?";

            if (minimum_count == 1 && maximum_count == int.MaxValue)
                return "(" + inner + "(" + joiner + inner + ")*)";

            if (minimum_count == 0)
                return "(" + inner + "(" + joiner + inner + "){0," + (maximum_count - 1) + "})?";

            return "(" + inner + "(" + joiner + inner + "){" + (minimum_count - 1) + "," + (maximum_count - 1) + "})";
        }

        public FragmentDefinition_Joined(string n) : base(n)
        {
        }

        public FragmentDefinition_Joined(string n, FragmentDefinition<T> f, FragmentDefinition j, int min, int max) : this(n)
        {
            Initialize(f, j, min, max);
        }

        public void Initialize(FragmentDefinition<T> f, FragmentDefinition j, int min, int max)
        {
            fragment_definition = f;
            joiner_definition = j;

            minimum_count = min;
            maximum_count = max;
        }

        public override bool CanConsumeNone()
        {
            if (minimum_count <= 0)
                return true;

            return fragment_definition.CanConsumeNone() && joiner_definition.CanConsumeNone();
        }

        public override string GetPsuedoRegEx()
        {
            string inner = fragment_definition.GetPsuedoRegEx();

            if (minimum_count == 0 && maximum_count == int.MaxValue)
                return inner + "*";

            if (minimum_count == 1 && maximum_count == int.MaxValue)
                return inner + "+";

            return inner + "{" + minimum_count + "," + maximum_count + "}";
        }
    }
    static public partial class FragmentDefinitions
    {
        static public FragmentDefinition<T[]> Joined<T>(string n, FragmentDefinition<T> f, FragmentDefinition j, int min, int max)
        {
            return new FragmentDefinition_Joined<T>(n, f, j, min, max);
        }
        static public FragmentDefinition<T[]> Joined<T>(FragmentDefinition<T> f, FragmentDefinition j, int min, int max)
        {
            return Joined(null, f, j, min, max);
        }

        static public FragmentDefinition<T[]> ZeroOrMoreJoined<T>(string n, FragmentDefinition<T> f, FragmentDefinition j)
        {
            return Joined(n, f, j, 0, int.MaxValue);
        }
        static public FragmentDefinition<T[]> ZeroOrMoreJoined<T>(FragmentDefinition<T> f, FragmentDefinition j)
        {
            return ZeroOrMoreJoined(null, f, j);
        }

        static public FragmentDefinition<T[]> OneOrMoreJoined<T>(string n, FragmentDefinition<T> f, FragmentDefinition j)
        {
            return Joined(n, f, j, 1, int.MaxValue);
        }
        static public FragmentDefinition<T[]> OneOrMoreJoined<T>(FragmentDefinition<T> f, FragmentDefinition j)
        {
            return OneOrMoreJoined(null, f, j);
        }
    }
}