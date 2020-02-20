using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class FragmentLibrary
    {
        private List<FragmentProvider> fragment_providers;
        private Dictionary<string, CmlFragment> manual_fragments;

        private OperationCache<CmlFragment, string> fragment_cache;

        public FragmentLibrary()
        {
            fragment_providers = new List<FragmentProvider>();
            manual_fragments = Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<CmlFragment_BuiltIn>(),
                Filterer_Type.IsConcreteClass()
            ).CreateInstances<CmlFragment>()
                .ToDictionaryValues(f => f.GetName());

            fragment_cache = new OperationCache<CmlFragment, string>("fragment_cache", delegate(string name) {
                return manual_fragments.GetValue(name) ??
                    fragment_providers.Convert(p => p.GetFragment(name)).GetFirstNonNull();
            });
        }

        public void AddFragment(CmlFragment fragment)
        {
            manual_fragments[fragment.GetName()] = fragment;
            fragment_cache.Clear();
        }

        public void AddFragmentProvider(FragmentProvider p)
        {
            fragment_providers.Add(p);
            fragment_cache.Clear();
        }

        public CmlFragment GetFragment(string name)
        {
            return fragment_cache.Fetch(name);
        }
    }
}