﻿using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Menu
{
    public class FragmentDefinition_Any<T> : FragmentDefinition<T>
    {
        private List<FragmentDefinition<T>> fragment_definitions;

        protected override bool ConsumeInternal(IList<TokenInstance> tokens, int index, out int new_index, out Operation<T> producer)
        {
            int best_index = -1;
            Operation<T> best_producer = null;

            foreach (FragmentDefinition<T> fragment_definition in fragment_definitions)
            {
                if (fragment_definition.Consume(tokens, index, out new_index, out producer))
                {
                    if (new_index >= best_index)
                    {
                        best_index = new_index;
                        best_producer = producer;
                    }
                }
            }

            if (best_producer != null)
            {
                new_index = best_index;
                producer = best_producer;
                return true;
            }

            new_index = -1;
            producer = null;
            return false;
        }

        public FragmentDefinition_Any(string n) : base(n)
        {
            fragment_definitions = new List<FragmentDefinition<T>>();
        }

        public FragmentDefinition_Any(string n, IEnumerable<FragmentDefinition<T>> f) : this(n)
        {
            Initialize(f);
        }
        public FragmentDefinition_Any(string n, params FragmentDefinition<T>[] f) : this(n, (IEnumerable<FragmentDefinition<T>>)f) { }

        public void Initialize(IEnumerable<FragmentDefinition<T>> f)
        {
            fragment_definitions.Set(f);
        }
        public void Initialize(params FragmentDefinition<T>[] f)
        {
            Initialize((IEnumerable<FragmentDefinition<T>>)f);
        }

        public override bool CanConsumeNone()
        {
            if (fragment_definitions.Has(f => f.CanConsumeNone()))
                return true;

            return false;
        }

        public override string GetPsuedoRegEx()
        {
            return "(" + fragment_definitions
                .Convert(f => f.GetPsuedoRegEx())
                .Join("|") + ")";
        }
    }
    static public partial class FragmentDefinitions
    {
        static public FragmentDefinition<T> Any<T>(string n, IEnumerable<FragmentDefinition<T>> f)
        {
            return new FragmentDefinition_Any<T>(n, f);
        }
        static public FragmentDefinition<T> Any<T>(string n, params FragmentDefinition<T>[] f)
        {
            return Any(n, (IEnumerable<FragmentDefinition<T>>)f);
        }

        static public FragmentDefinition<T> Any<T>(IEnumerable<FragmentDefinition<T>> f)
        {
            return Any(null, f);
        }
        static public FragmentDefinition<T> Any<T>(params FragmentDefinition<T>[] f)
        {
            return Any(null, f);
        }
    }
}