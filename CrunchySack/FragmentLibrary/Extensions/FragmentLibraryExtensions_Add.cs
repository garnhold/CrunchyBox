using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class FragmentLibraryExtensions_Add
    {
        static public void AddFragments(this FragmentLibrary item, IEnumerable<CmlFragment> to_add)
        {
            to_add.Process(f => item.AddFragment(f));
        }
        static public void AddFragments(this FragmentLibrary item, params CmlFragment[] to_add)
        {
            item.AddFragments((IEnumerable<CmlFragment>)to_add);
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