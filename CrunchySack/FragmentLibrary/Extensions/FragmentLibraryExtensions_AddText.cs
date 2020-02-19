using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class FragmentLibraryExtensions_AddText
    {
        static public void AddFragment(this FragmentLibrary item, string name, string text)
        {
            item.AddFragment(
                new CmlFragment_FragmentDefinition(
                    name,
                    CmlFragmentDefinition.DOMify(text)
                )
            );
        }
    }
}