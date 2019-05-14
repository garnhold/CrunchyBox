using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public class FragmentLibrary
    {
        private List<FragmentProvider> fragment_providers;
        private Dictionary<string, CmlEntry_Fragment> manual_fragments;

        private OperationCache<CmlEntry_Fragment, string> fragment_cache;

        public FragmentLibrary()
        {
            fragment_providers = new List<FragmentProvider>();
            manual_fragments = Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<CmlEntry_Fragment_BuiltIn>(),
                Filterer_Type.IsConcreteClass()
            ).CreateInstances<CmlEntry_Fragment>()
                .ToDictionaryValues(f => f.GetName());

            fragment_cache = new OperationCache<CmlEntry_Fragment, string>(delegate(string name) {
                return manual_fragments.GetValue(name) ??
                    fragment_providers.Convert(p => p.GetFragment(name)).GetFirstNonNull();
            });
        }

        public void AddFragment(CmlEntry_Fragment fragment)
        {
            manual_fragments[fragment.GetName()] = fragment;
            fragment_cache.Clear();
        }

        public void AddFragmentProvider(FragmentProvider p)
        {
            fragment_providers.Add(p);
            fragment_cache.Clear();
        }

        public CmlEntry_Fragment GetFragment(string name)
        {
            return fragment_cache.Fetch(name);
        }
    }
}