using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    static public class FragmentLibraryExtensions_Add
    {
        static public void AddFragments(this FragmentLibrary item, IEnumerable<CmlEntry_Fragment> to_add)
        {
            to_add.Process(f => item.AddFragment(f));
        }
        static public void AddFragments(this FragmentLibrary item, params CmlEntry_Fragment[] to_add)
        {
            item.AddFragments((IEnumerable<CmlEntry_Fragment>)to_add);
        }

        static public void AddFragmentProviders(this FragmentLibrary item, IEnumerable<FragmentProvider> to_add)
        {
            to_add.Process(f => item.AddFragmentProvider(f));
        }
        static public void AddFragmentProviders(this FragmentLibrary item, params FragmentProvider[] to_add)
        {
            item.AddFragmentProviders((IEnumerable<FragmentProvider>)to_add);
        }
    }
}